using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

class LocalData
{
    /// <summary>
    /// ファイルを読み込みます
    /// </summary>
    /// <typeparam name="T">クラスの型</typeparam>
    /// <param name="filepath">ファイル名</param>
    /// <param name="enc">暗号化をかけたいときに指定</param>
    /// <returns></returns>
    static public T Load<T>(string filepath, bool enc = false)
    {
        //ファイルがなかったらdefaultで返す
        if (!File.Exists(filepath))
        {
            return default;
        }

        var data = File.ReadAllBytes(filepath);
#if RELEASE
        arr = AesDecrypt(arr);
#else
        if (enc)
        {
            data = AesDecrypt(data);
        }
#endif

        string json = Encoding.UTF8.GetString(data);
        return JsonUtility.FromJson<T>(json);
    }

    /// <summary>
    /// ファイルを保存します
    /// </summary>
    /// <typeparam name="T">クラスの型</typeparam>
    /// <param name="filepath">ファイル名</param>
    /// <param name="data">セーブするデータ</param>
    /// <param name="enc">暗号化をかけたいときに指定</param>
    /// <returns></returns>
    static public void Save<T>(string filepath, T dataObj, bool enc = false)
    {
        var json = JsonUtility.ToJson(dataObj);
        byte[] data = Encoding.UTF8.GetBytes(json);
#if RELEASE
        arr = AesEncrypt(arr);
#else
        if (enc)
        {
            data = AesEncrypt(data);
        }
#endif
        var pathes = (filepath).Split('/').ToList();
        pathes.RemoveAt(pathes.Count - 1);
        var dir = string.Join("/", pathes);
        if (!Directory.Exists(dir))
        {
            Directory.CreateDirectory(dir);
        }
        File.WriteAllBytes(filepath, data);
    }

    /// <summary>
    /// ファイルを消します
    /// </summary>
    /// <param name="filepath">ファイル名を指定</param>
    /// <returns></returns>
    static public void Delete(string filepath)
    {
        if (!File.Exists(filepath))
        {
            return;
        }

        File.Delete(filepath);
    }


    //ここから下は見なくていいコード


    /// <summary>
    /// AES暗号化
    /// </summary>
    static public byte[] AesEncrypt(byte[] byteText)
    {
        // AES設定値
        //===================================
        int aesKeySize = 128;
        int aesBlockSize = 128;
        string aesIv = "cCYcP6Is7Y6EpGN9";
        string aesKey = "ieSeuIx0ZF4s8s1M";
        //===================================

        // AESマネージャー取得
        var aes = GetAesManager(aesKeySize, aesBlockSize, aesIv, aesKey);
        // 暗号化
        byte[] encryptText = aes.CreateEncryptor().TransformFinalBlock(byteText, 0, byteText.Length);

        return encryptText;
    }

    /// <summary>
    /// AES復号化
    /// </summary>
    static public byte[] AesDecrypt(byte[] byteText)
    {
        // AES設定値
        //===================================
        int aesKeySize = 128;
        int aesBlockSize = 128;
        string aesIv = "cCYcP6Is7Y6EpGN9";
        string aesKey = "ieSeuIx0ZF4s8s1M";
        //===================================

        // AESマネージャー取得
        var aes = GetAesManager(aesKeySize, aesBlockSize, aesIv, aesKey);
        // 復号化
        byte[] decryptText = aes.CreateDecryptor().TransformFinalBlock(byteText, 0, byteText.Length);

        return decryptText;
    }

    /// <summary>
    /// AesManagedを取得
    /// </summary>
    /// <param name="keySize">暗号化鍵の長さ</param>
    /// <param name="blockSize">ブロックサイズ</param>
    /// <param name="iv">初期化ベクトル(半角X文字（8bit * X = [keySize]bit))</param>
    /// <param name="key">暗号化鍵 (半X文字（8bit * X文字 = [keySize]bit）)</param>
    static private AesManaged GetAesManager(int keySize, int blockSize, string iv, string key)
    {
        AesManaged aes = new AesManaged();
        aes.KeySize = keySize;
        aes.BlockSize = blockSize;
        aes.Mode = CipherMode.CBC;
        aes.IV = Encoding.UTF8.GetBytes(iv);
        aes.Key = Encoding.UTF8.GetBytes(key);
        aes.Padding = PaddingMode.PKCS7;
        return aes;
    }


    /// <summary>
    /// XOR
    /// </summary>
    static public byte[] Xor(byte[] a, byte[] b)
    {
        int j = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (j < b.Length)
            {
                j++;
            }
            else
            {
                j = 1;
            }
            a[i] = (byte)(a[i] ^ b[j - 1]);
        }
        return a;
    }
}