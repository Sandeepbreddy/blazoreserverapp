using survey_proj.Data;

public interface ISurveyService
{
    Task<IEnumerable<SurveyModel>> GetAllSurveysAsync();
    Task<SurveyOperator> GetSurveyOperatorAsync();
    Task<List<SurveyDetails>> GetSurveyDetailsAsync();
}