using System;


namespace hackathon_cs9 {
    
    public class Records {
        public record Record { 
            public string Title { get; init; }
            public string Tracks { get; init; }
        }

        public record ShortRecord(string ShortName, string ShortTracks);
        
        public record FullRecord // : IEquatable<FullRecord> {
            public FullRecord(string recordName, string recordTracks, 
                               string composer, string distributionCompany) {
                this.RecordName = recordName;
                this.RecordTracks = recordTracks;
                this.Composer = composer;
                this.DistributionCompany = distributionCompany;                 
            }

            public strring RecordName {get; init;} 
            public strring RecordTracks {get; init;}
            public strring Composer {get; init;}
            public strring DistributionCompany {get; init;}
            
            // public virtual bool Equals(FullRecord fullRecord) {
            //     var equal = this.RecordName == fullRecord.RecordName && 
            //             this.RecordTracks == fullRecord.RecordTracks && 
            //             this.Composer == fullRecord.Composer && 
            //             this.DistributionCompany == fullRecord.DistributionCompany;
            //     return equal; 
            // } 

            // public static bool operator==(FullRecord record1, FullRecord record2) {
            //     return record1.Equals(record2);
            // } 

            // public static bool operator!=(FullRecord record1, FullRecord record2) {
            //     return !record1.Equals(record2);
            // }
        } 

        public void DoSomeRecordStuff() {
            var rec1 = new Record { 
                Title="the record title", 
                Tracks="some tracks"};


            var rec2 = rec1 with { Title = "Title 2" };

            // Works 
            var short_record = new ShortRecord("Short Name", "ShortTracks");



            Console.WriteLine(rec1);
            Console.WriteLine(rec2);
            Console.WriteLine(short_record);

            var full_record1 = new FullRecord("Full Name", "Full tracks", "Composer", "Distro");
            var full_record2 = full_record1 with { RecordName = "Full Name-2" };
            //  new FullRecord("Full Name", "Full tracks", "Composer", "Distro");
            Console.WriteLine(full_record1.Equals(full_record2));
            Console.WriteLine(full_record1 == full_record2);
            Console.WriteLine(full_record1 != full_record2);
            
        }       
    }
}