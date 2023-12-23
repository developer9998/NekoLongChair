using MelonLoader;
using NekoLongChair;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: MelonInfo(typeof(LongChairMod), "NekoLongChair", "1.0.0", "dev")]

namespace NekoLongChair
{
    public class LongChairMod : MelonMod
    {
        private Transform m_RootEnv, m_Chair;

        public override void OnSceneWasInitialized(int buildIndex, string sceneName)
        {
            if (sceneName == "SceneSub")
            {
                Scene activeScene = SceneManager.GetSceneByBuildIndex(buildIndex);

                foreach (GameObject rootObject in activeScene.GetRootGameObjects())
                {
                    if (rootObject.name == "Environment")
                    {
                        m_RootEnv = rootObject.transform;
                        m_Chair = m_RootEnv.Find("TestBG01_Niwa24_Fix_pref/Bone_Chair/Bone");
                        m_Chair.localScale = new Vector3(4f, 1f, 1f);
                        break;
                    }
                }
            }
        }
    }
}
