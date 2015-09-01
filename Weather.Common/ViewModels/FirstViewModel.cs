using Cirrious.MvvmCross.ViewModels;
using Weather.Common.Model;
using Weather.Common.Services;


namespace Weather.Common.ViewModels
{
    public class FirstViewModel
        : MvxViewModel
    {
        private DailyTemperature _dailyTemperature;
        private MvxCommand _nextCommand;
        private MvxCommand _previousCommand;
        private IWeatherService _weatherService;
        private bool _isPrevious;
        private bool _isNext;

        public DailyTemperature DailyTemperature
        {
            get { return _dailyTemperature; }
            set
            {
                _dailyTemperature = value;
                RaisePropertyChanged(() => DailyTemperature);
            }
        }

        public IMvxCommand NextCommand
        {
            get
            {
                return _nextCommand;
            }
        }

        public IMvxCommand PreviousCommand
        {
            get
            {
                return _previousCommand;
            }
        }

        public bool IsPrevious
        {
            get { return _isPrevious; }
            set
            {
                _isPrevious = value;
                RaisePropertyChanged(() => IsPrevious);
            }

        }

        public bool IsNext
        {
            get { return _isNext; }
            set
            {
                _isNext = value;
                RaisePropertyChanged(() => IsNext);
            }
        }

        public FirstViewModel(IWeatherService weatherService)
        {
            this._weatherService = weatherService;
        }

        public override void Start()
        {
            base.Start();
            _nextCommand = new MvxCommand(() => NextCommandExecuted());
            _previousCommand = new MvxCommand(() => PreviousCommandExecuted());
            PageLoad();
        }

        private async void PageLoad()
        {
            await this._weatherService.GetDailyWeatherDataAsync();
            DailyTemperature = await this._weatherService.GetFirst();
            ValidateNavigation();
        }

        private void ValidateNavigation()
        {
            IsNext = this._weatherService.IsNext;
            IsPrevious = this._weatherService.IsPrevious;
        }

        private async void NextCommandExecuted()
        {
            DailyTemperature = await this._weatherService.GetNext();
            ValidateNavigation();
        }

        private async void PreviousCommandExecuted()
        {
            DailyTemperature = await this._weatherService.GetPrevious();
            ValidateNavigation();
        }
    }
}
