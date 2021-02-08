using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerBills;

namespace fixture
{
    namespace CustomerBills
    {
        public class FixtureCustomerType : CustomerType
        {
            public FixtureCustomerType() : base(name, included_mins, included_texts, monthly_cost, first_tier_mins,
                first_tier_rate, second_tier_mins, second_tier_rate, rate_per_min, text_cost) { }

            public const string name = "Customer fixture";
            public const int included_mins = 1000;
            public const int included_texts = 800;
            public const int monthly_cost = 30;
            public const int first_tier_mins = 500;
            public const float first_tier_rate = 0.08f;
            public const int second_tier_mins = 400;
            public const float second_tier_rate = 0.06f;
            public const float rate_per_min = 0.05f;
            public const float text_cost = 0.07f;

            public const float total_first_tier_cost = 40f;
            public const float total_second_tier_cost = 24f;
        }
    }
}

