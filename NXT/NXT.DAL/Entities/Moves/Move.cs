
﻿using NXT.DAL.Entities.Generations;
﻿using NXT.DAL.Entities.Pokemons;
using System.Collections.Generic;
namespace NXT.DAL.Entities.Moves
{
    public class Move
    {

        public int Id { get; set; }
        public string Identifier { get; set; }
         
        public int Power { get; set; }
        public int PP { get; set; }
        public int Accuracy { get; set; }
        public int Priority { get; set; }
        public int EffectChance { get; set; }

        //foreign
        public MoveDamageClass MoveDamageClass { get; set; }
        public MoveMeta MoveMeta { get; set; }
        public MoveEffect Effect { get; set; }
        public Type Type { get; set; }
        public Generation Generation { get; set; }
        public MoveMetaCategory MetaCategory { get; set; }

        public ICollection<MoveChangelog> MoveChangelogs { get; set; }
        public ICollection<MoveTarget> Targets { get; set; }
        public ICollection<MoveBattleStyle> BattleStyles { get; set; }
        public ICollection<MoveMetaAilment> MetaAilments { get; set; }
    }
}