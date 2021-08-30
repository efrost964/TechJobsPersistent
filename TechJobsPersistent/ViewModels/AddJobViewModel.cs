﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TechJobsPersistent.Data;
using TechJobsPersistent.Models;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        //public List<SelectListItem> Employers { get; set; }

        //[Required(ErrorMessage = "Job name is required.")]
        //public string Name { get; set; }
        //[Required(ErrorMessage = "Employer is required.")]
        //public int EmployerId { get; set; }
        //[Required(ErrorMessage = "Skill is required.")]
        //public List<Skill> Skills { get; set; }
        //public AddJobViewModel(List<Employer> employers, List<Skill> skills)
        //{
        //    Employers = new List<SelectListItem>();

        //    foreach (Employer employer in employers)
        //    {
        //        Employers.Add(new SelectListItem
        //        {
        //            Value = employer.Id.ToString(),
        //            Text = employer.Name
        //        });

        //    }
        //    Skills=skills;
        //}
        //public AddJobViewModel()
        //{

        //}
        public void createSelectListItems(List<Employer> employers)
        {
            this.Employers = new List<SelectListItem>();

            foreach (Employer employer in employers)
            {
                this.Employers.Add(
                    new SelectListItem
                    {
                        Value = employer.Id.ToString(),
                        Text = employer.Name
                    });
            }
        }
        //public static List<Employer> employers = _context.Employers.ToList();
        //public List<SelectListItem> Employers;


        public string Name { get; set; }

            public int EmployerId { get; set; }

            public List<SelectListItem> Employers { get; set; }

            public List<int> SkillId { get; set; }

            public List<Skill> Skills { get; set; }

            public AddJobViewModel(List<Employer> employers, List<Skill> skills)
            {
                Employers = new List<SelectListItem>();

                foreach (var employer in employers)
                {
                    Employers.Add(new SelectListItem
                    {
                        Value = employer.Id.ToString(),
                        Text = employer.Name
                    });
                }

                Skills = skills;
            }

            public AddJobViewModel()
            {

            }

        }



    }

