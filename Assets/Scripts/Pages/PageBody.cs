using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

namespace Pages
{
    [RequireComponent(typeof(Page))]
    public class PageBody : MonoBehaviour
    {
        [Header("Data")]
        public int pageId;
        public int[] nextPageIds;
        [Header("Objects")]
        [SerializeField] private VideoPlayer videoPlayer;
        [SerializeField] private RawImage videoImage;
        [SerializeField] private Image image;
        [Header("Bool")]
        public bool isWatched = false;
        public void Awake()
        {
            videoPlayer.loopPointReached += (e) => isWatched = true;
        }
        
        public void OnPageEnter()
        {
            gameObject.SetActive(true);
            if(isWatched)
            {
                videoPlayer.time = 0f;
                videoPlayer.Play();
            }
        }

        public void OnPageExit()
        {
            if(isWatched)
            {
                videoPlayer.Stop();
            }
            gameObject.SetActive(false);
        }
    }
}