using System;
using ExperienceGenerator.Exm.Services;

namespace ExperienceGenerator.Exm.Models
{
	public class ExmJob
	{
		public Guid Id { get; set; }

		public ExmJob()
		{
			Id = Guid.NewGuid();
		}

		public DateTime? Started { get; set; }

		public DateTime? Ended { get; set; }

		public JobStatus JobStatus { get; set; }

		public int CompletedContacts { get; set; }

    public int TargetContacts { get; set; }

    public int CompletedEmails { get; set; }

    public int TargetEmails { get; set; }

    public int CompletedEvents { get; set; }

    public int TargetEvents { get; set; }

    public int CompletedLists { get; set; }

    public int TargetLists { get; set; }

    public string CampaignCountLabel { get; set; }

    public string Status { get; set; }

		public string LastException { get; set; }

		public string StatusUrl { get; set; }

    public double Progress
    {
      get
      {
        if (TargetEmails + TargetContacts + TargetEvents + TargetLists == 0) return 0d;

        var contactsProgress = TargetContacts == 0 ? 1d : (double)CompletedContacts / (double)TargetContacts;
        var emailsProgress = TargetEmails == 0 ? 1d : (double)CompletedEmails / (double)TargetEmails;
        var eventsProgress = TargetEvents == 0 ? 1d : (double)CompletedEvents / (double)TargetEvents;

        return (contactsProgress * 0.1) + (emailsProgress * 0.2) + (eventsProgress * 0.7);

      }
    }
    public int OpenSlots => ExmEventsGenerator.Pool?.CurrentCount ?? 0;

	  public int Errors => ExmEventsGenerator.Errors;

	  public int Timeouts => ExmEventsGenerator.Timeouts;

	  public int TotalContacts { get; set; }
  }
}