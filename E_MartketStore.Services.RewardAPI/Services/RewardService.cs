namespace E_MartketStore.Services.RewardAPI.Services
{
    public class RewardService : IRewardService
    {
        private readonly IRewardService _rewardService;

        public RewardService(IRewardService rewardService)
        {
            _rewardService = rewardService;
        }
    }
}
