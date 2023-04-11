using DeskUniverse_Frontend.Models;

public class SkillService
{
    public Skill SkillData { get; set; } = new Skill();

    public void SkillSave(Skill _Skill)
    {   
        SkillData = _Skill;
    }
}