using System.Collections.Generic;
using System.Linq;
using Sirenix.OdinInspector;
using UnityEngine;

namespace VoxelCraft.UI.Flow
{
    [CreateAssetMenu(menuName = "ScreenFlow/Config", fileName = nameof(ScreenFlowConfig))]
    public class ScreenFlowConfig : ScriptableObject
    {
        [Space] [TableList] [SerializeField] private List<ScreenConfig> configs;


        public ScreenType TypeOf(ScreenID id)
        {
            return (from config in configs where config.id == id select config.type).FirstOrDefault();
        }

        public string AddressOf(ScreenID id)
        {
            return (from config in configs where config.id == id select config.address).FirstOrDefault();
        }
    }
}