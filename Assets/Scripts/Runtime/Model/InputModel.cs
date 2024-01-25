using Runtime.Data.UnityObject;
using Runtime.Data.ValueObject;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Runtime.Model
{
    public class InputModel : IInputModel
    {
        private InputVO _inputVo { get; set; }

        [ShowInInspector] public int CurrentLevel { get; set; }

        [ShowInInspector]
        public InputVO InputVo
        {
            get
            {
                if (_inputVo == null)
                {
                    OnPostConstruct();
                }

                return _inputVo;
            }
            set => _inputVo = value;
        }

        [ShowInInspector]
        

        //
        [PostConstruct]
        private void OnPostConstruct()
        {
            _inputVo = new InputVO();
            CD_Input inputSo = Resources.Load<CD_Input>("Data/CD_Input");
            _inputVo = inputSo.InputData;
        }
    }
}