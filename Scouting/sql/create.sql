CREATE TABLE IF NOT EXISTS Scouting (
	EntryID	INTEGER,
	Stage	TEXT NOT NULL,
	SetNo	INTEGER NOT NULL,
	MatchNo	INTEGER NOT NULL,
	Team	INTEGER NOT NULL,
	PRIMARY KEY(EntryID)
);