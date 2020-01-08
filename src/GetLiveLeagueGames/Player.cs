﻿namespace HGV.Daedalus.GetLiveLeagueGames
{
    public class Player
    {
        public int player_slot { get; set; }
        public uint account_id { get; set; }
        public int hero_id { get; set; }
        public int kills { get; set; }
        public int death { get; set; }
        public int assists { get; set; }
        public int last_hits { get; set; }
        public int denies { get; set; }
        public int gold { get; set; }
        public int level { get; set; }
        public int gold_per_min { get; set; }
        public int xp_per_min { get; set; }
        public int ultimate_state { get; set; }
        public int ultimate_cooldown { get; set; }
        public int item0 { get; set; }
        public int item1 { get; set; }
        public int item2 { get; set; }
        public int item3 { get; set; }
        public int item4 { get; set; }
        public int item5 { get; set; }
        public int respawn_timer { get; set; }
        public double position_x { get; set; }
        public double position_y { get; set; }
        public int net_worth { get; set; }
    }

}
