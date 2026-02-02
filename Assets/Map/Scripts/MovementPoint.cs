using UnityEngine;

namespace GJAM4.Map
{
    public class MovementPoint : MonoBehaviour
    {
        #region Variables

        [SerializeField] private bool _canMoveForward;

        [SerializeField] private bool _canTurnLeft;

        [SerializeField] private bool _canTurnRight;

        #endregion

        #region Methods

        private void InitializeMovementPoint()
        {
            if (_canMoveForward)
            {
                // Enable moving forward
            }
            if (_canTurnLeft)
            {
                // Enable turning left
            }
            if (_canTurnRight)
            {
                // Enable turning right
            }
        }

        #endregion

        #region Unity Methods

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            InitializeMovementPoint();
        }

        #endregion
    }
}