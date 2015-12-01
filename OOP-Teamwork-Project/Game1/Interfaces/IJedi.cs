using SWRPG.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SWRPG.Interfaces
{
    interface IJedi
    {
        int ForceAbsorbLevel { get; set; }
        int ForceHealLevel { get; set; }
        int MindTrickLevel { get; set; }
        int ProtectionLevel { get; set; }

        int PushLevel { get; set; }
        int PullLevel { get; set; }
        int JumpLevel { get; set; }
        int SpeedLevel { get; set; }
        int LightsaberThrowLevel { get; set; }

        int ForceDrainLevel { get; set; }
        int LightingLevel { get; set; }
        int GripLevel { get; set; }
        int RageLevel { get; set; }

        void ForceAbsorb(); // decrease nearby jedi's force and increase your own
        void ForceHeal(); // decrease your force to increase your health
        void MindTrick(); // distract nearby enemies and decrease their chance of hit
        void Protect(); // increase shield and decrease force

        void Push(Character enemy); //push nearby enemies
        void Pull(Character enemy); // pull nearby enemies closer
        void IncreaseJump();
        void IncreaseSpeed();
        void ThrowLightsaber();

        void ForceDrain(); //decrease health of nearby enemies to increase your own health
        void ForceLighting(Character enemy); // attack with electricity
        void ForceGrip(Character enemy); // chokes enemy and for few seconds the enemy cannot move or attack
        void ForceRage(); // in exchange of health jedi gets boost of speed, jump and shield
    }
}
