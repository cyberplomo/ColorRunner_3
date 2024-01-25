using System.Collections.Generic;
using Runtime.Data.UnityObject;
using Runtime.Data.ValueObject;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Runtime.Model
{
    public class PlayerModel : IPlayerModel
    {
        private PlayerVO _playerVo { get; set; }

        [ShowInInspector] public int CurrentLevel { get; set; }

        public int KilledEnemyCount { get; set; }

        [ShowInInspector]
        public PlayerVO PlayerVo
        {
            get
            {
                if (_playerVo == null)
                {
                    OnPostConstruct();
                }

                return _playerVo;
            }
            set => _playerVo = value;
        }

        [ShowInInspector]
    

        //
        [PostConstruct]
        private void OnPostConstruct()
        {
            _playerVo = new PlayerVO();
            CD_Player playerSo = Resources.Load<CD_Player>("Data/CD_Player");
            _playerVo = playerSo.playerData;
        }
    }
}