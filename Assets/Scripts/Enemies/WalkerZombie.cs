using UnityEngine;

namespace ST07.Enemies
{
    // 기본 워커: ZombieAI 기본 동작/수치 사용
    public class WalkerZombie : ZombieAI
    {
        protected override void Awake()
        {
            base.Awake(); // 부모 초기화 먼저!
            attackDamage = 10f; // 기본 데미지
        }
    }
}


