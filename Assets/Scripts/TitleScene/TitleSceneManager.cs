using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSceneManager : MonoBehaviour
{
    /// <summary>
    /// soundManagerが使われるタイミングでシーン上から探索する
    /// </summary>
    private SoundManager soundManager => FindAnyObjectByType<SoundManager>();

    /// <summary>
    /// BGMがフェードインする時間
    /// </summary>
    public float FadeDuration = 2f;


    private void Start()
    {
        StartCoroutine(FadeInBGM());

    }
    /// <summary>
    /// インゲームのシーンに移行する
    /// </summary>
    public void GotoInGameScene()
    {
        // SEを鳴らす
        // soundManager.PlaySE();
        // SceneManager.LoadScene(GameSceneUtility.SampleSceneName);
        StartCoroutine(SceneTransition());

    }

    /// <summary>
    /// SEがなり終わるのを、待った後にシーンを遷移させる
    /// </summary>
    /// <returns></returns>
    public IEnumerator SceneTransition()
    {
        //SEを鳴らす→ここにあるのはすごく嫌なので後で変える
        soundManager.PlaySE();
        //yield return new WaitForSeconds(1);
        //SEが鳴っている間待つ
        yield return new WaitWhile(()=> soundManager.IsSEAudioSourcesPlaying());
        SceneManager.LoadScene(GameSceneUtility.SampleSceneName);

    }
    /// <summary>
    /// 遅れてBGMの再生をする
    /// </summary>
    /// <returns></returns>
    public IEnumerator FadeInBGM()
    {

        
        //soundManagerがnullじゃなければ
        if(soundManager != null)
        {
            //BGMを再生する
            soundManager.PlayBGM();

            soundManager.GetBGMAudioSource.volume = 0;

            var elapsedTime = 0f;

            //経過時間がFadeDurationの値を超えるまで
            while(elapsedTime < FadeDuration)
            {
                //フェードインのボリュームを計算
                //0か1の間で線形補間をおこなった結果をボリュームの値に代入する
                soundManager.GetBGMAudioSource.volume = Mathf.Lerp(0f, 1, elapsedTime / FadeDuration);

                //経過時間を更新する
                elapsedTime+= Time.deltaTime;

                //１フレーム待機する
                yield return null;

            }

            soundManager.GetBGMAudioSource.volume = 1f;

        }
    }

}

