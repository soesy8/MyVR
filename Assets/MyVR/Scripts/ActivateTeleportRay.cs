using UnityEngine;
using UnityEngine.InputSystem;

namespace MyVR
{
    public class ActivateTeleportRay : MonoBehaviour
    {
        public GameObject leftTeleportRay;
        public GameObject rightTeleportRay;

        //Activate 버튼 인풋
        public InputActionProperty leftActivate;
        public InputActionProperty rightActivate;

        private void Update()
        {
            //Activate 버튼 인풋
            float leftValue = leftActivate.action.ReadValue<float>();
            float rightValue = rightActivate.action.ReadValue<float>();

            //텔레포트 레이 활성화/비활성화
            leftTeleportRay.SetActive(leftValue > 0.1f);
            rightTeleportRay.SetActive(rightValue > 0.1f);
        }
    }
}