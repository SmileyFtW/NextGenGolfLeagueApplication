# Table of Contents

[Next Gen Golf League Application – Read Me](#next-gen-golf-league-application-read-me)    
[Background and Why We Torture Ourselves With This Project](#background-and-why-we-torture-ourselves-with-this-project)    
[Project Process](#project-process)    
[Instructions for Installing GLA](#instructions-for-installing-gla)   
[Instructions for Contributing to the GLA Project](#instructions-for-contributing-to-the-gla-project)   
[How Can I Help?](#how-can-i-help)   
[Project License](#project-license)   
[Resources and External Licensing](#resources-and-external-licensing)   
[Contact Information and Asking Questions](#contact-information-and-asking-questions)   
[Appendix I](#appendix-i)   
[GLA - Inception Iteration](#gla---inception-iteration)

# Next Gen Golf League Application – Read Me

## Background and Why We Torture Ourselves With This Project

This Next Generation Golf League Application (NextGen GLA, or “GLA” for
short) project is intended to replace two existing (ugly and
unmaintainable) separate applications currently hosted in Microsoft
Excel and implemented in Visual Basic for Applications (VBA). Each
separate application supports league scoring and reporting for two
independent golf leagues: the Avionics Golf League (AGL) and the Fighter
Enterprise Golf League (FEGL). Each league shares common needs, such as
a player roster, team roster, matches schedule, and round reporting.
Each league has league-specific needs, such as scoring rules,
handicapping, and team composition. *Tidbit: the AGL has been in
existence since 1964. It was started by aerospace engineers that moved
from California to Texas and was based on their golf league in
California. The rules have changed somewhat over the years, but the
flavor of the AGL remains true to its original roots. All league
activities were done by hand*.

The GLA has common code elements to support common needs while providing
flexibility, expandability, and maintainability to support league-unique
aspects. Additionally, since league rules change over time the GLA is
designed to support those changes. This approach implies that virtually
any league could be supported by creating the unique aspects while
leveraging elements that are common to all leagues: rosters, schedules,
and reporting.

The GLA is written in C\# and is in a GitHub Repository (*link to
repository*). The owner of the repository at inception is David G.
Miley. Two principal contributors at inception are Chris Sell and
Charlie Bean. All three individuals have acted in leadership roles for
the AGL. David currently leads the FEGL and is primarily responsible for
both current Excel implementations with contributions to the AGL
application by Chris. Chris and Charlie are both developers and in
leadership positions in the aerospace industry. David is retired and
works at a golf course.

Other files beyond this ReadMe provide more details of the GLA project
and its iterations. As of this writing those files include UseCase.docx
and Glossary.docx. The next document to be added is the First
Elaboration Iteration. Certainly, more documents are to be added as the
project grows.

We invite others to help us in this project. For some perspective we
provide the following:

## Project Process

The project follows the process described in “Applying UML And Patterns”
by Craig Larman (3<sup>rd</sup> Ed). For specific references cited in
this project’s documents the following notation is used “(AUAP pp nn)”,
where “AUAP” is shorthand for the book title and “pp nn” refers to the
page(s) where the information can be found.

The basic premise of the process in AUAP is that software development is
iterative and not “waterfall”. Waterfall processes require a fully
mature set of requirements before development begins. Iterative
development begins with some fundamental requirements which may or may
not be fully understood, codes in production form to those requirements,
refining and expanding in each iteration. It is understood that there is
always change in software requirements, even in mature applications.
This project most certainly is iterative in nature.

There are four phases in the UP Process defined in AUAP (pp 33):

1)  Inception – a single event to approximate vision, show the business
    case, bound the scope, develop vague estimates

2)  Elaboration – a series of iterations that refine vision, implement
    the core architecture, resolve high risks, identify most
    requirements and scope, develop more realistic estimates

3)  Construction – a series of iterations implementing the remaining
    (lower) risks and easier elements, preparation for deployment

4)  Transition – beta testing, deployment

> Refinement (R) for this project implies significant changes may occur based on ongoing efforts and are limited generally to the phase immediately following the Artifact start.
>
> Update (U) implies minor edits to the Artifact to provide clarity/brevity or correct errors.

| Discipline        | Artifact                    | Inception | Elaboration | Construction | Transition |
| ----------------- | --------------------------- | --------- | ----------- | ------------ | ---------- |
| Business Modeling | Iterations \>               | I1        | E1…En       | C1…Cn        | T1…T2      |
|                   | Domain Model                |           | **S**       |              |            |
| Requirements      | Use-Case Model              | **S**     | **R**       |              |            |
|                   | Vision                      | **S**     | **R**       |              |            |
|                   | Supplementary Specification | **S**     | **R**       | **U**        |            |
|                   | Glossary                    | **S**     | **R**       | **U**        |            |
| Design            | Design Model                |           | **S**       | **R**        |            |
|                   | SW Architecture Document    |           | **S**       | **U**        |            |
|                   | Data Model                  |           | **S**       | **R**        |            |
| Implementation    | Implementation Model        |           | **S**       | **R**        | **R**      |

Table 1 – Unified Process (UP) Artifacts & Timing (S=start; R=refine,
U=update)

The first iteration, [GLA Inception](#gla---inception-iteration), is
included as part of this ReadMe in Appendix I and not maintained as a
separate document. Subsequent iteration records and other supporting
documents are added to the GitHub Repository as the project matures. As
outlined in AUAP there are several artifacts normally generated in the
Inception iteration that serve to advance the thinking and analysis of a
project. Not all artifacts are useful in every project; this project
uses only the items that add value and understanding; they are also
revised iteratively. This project is an informal one supported by
volunteers and uses artifacts to provide insight, guidance, decision
history, and structure.

The Inception iteration Artifacts from AUAP:

1)  **Vision and Business Case**: high level goals and constraints.

2)  **Use Case Model**: functional requirements

3)  **Supplementary Specification**: anything that is not a functional
    requirement

4)  **Glossary**: key terminology and data dictionary

5)  **Risk List & Risk Management Plan**: risks descriptions and ideas
    for mitigation

6)  **Prototypes & Proof-of-Conce**pts: clarify vision and validate
    technical ideas

7)  **Iteration Plan**: what to do in the first Elaboration iteration

8)  **Phase Plan & Software Development Plan**: low precision for
    elaboration duration/efforts

9)  **Development Case**: description of the Unified Process (UP) steps
    for this project

## Instructions for Installing GLA

Since the project currently has no code there is nothing to install.
So, what are you waiting for? Help us get this thing installable\!

## Instructions for Contributing to the GLA Project

Who can contribute? We welcome anyone to contribute.

What do I need to do to contribute? Become familiar with the structure of the project and understand the Project Process we are following. It's in this ReadMe above.

What coding style is used? We are learning about and endeavoring to apply best practices such as SOLID and using Design Patterns (GoF).

What language is the project in? We are developing in C\# so knowledge of that language is certainly a plus. The legacy work was done in Excel VBA.

I don’t know anything about golf. Is that a problem? You'll likely learn more than you ever wanted to know, but no you don't need to know anything about golf or its rules.

## How Can I Help?

Do I need to be a developer or are there other ways to help?

We want to transition to a web interface for any league that wants to
use the application, so web developers would be a great help.

We want to expand this in the future to support other golf leagues.
Spreading the word to golfers and golf leagues will be something we will
want.

Are you a golfer? Know the rules? Have a league of your own? Provide
your insights.

## Project License

Proposed:

NextGen Golf League Application (GLA) is a stand-alone application to
support golf league management of player and team rosters, budgeting,
scheduling, and reporting.

Copyright (C) 2019 NextGen Golf League Application project contributors

This program is free software: you can redistribute it and/or modify it
under the terms of the GNU General Public License as published by the
Free Software Foundation, either version 3 of the License, or (at your
option) any later version.

This program is distributed in the hope that it will be useful, but
WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU General
Public License for more details.

You should have received a copy of the GNU General Public License along
with this program. If not, see <http://www.gnu.org/licenses/>.

## Resources and External Licensing

None at this writing
## Contact Information and Asking Questions

A GLA domain NextGenGolfLeagueApp.org may be registered (that domain is
currently available) to allow for future expansion to a web interface
for leagues that subscribe to the service and to provide email addresses
for principal contributors and help.

Specifically, there could be a <help@NextGenGolfLeagueApp.org> to handle
questions.

Additionally, a Stack Exchange Chat Room could be set up.

# Appendix I

## GLA - Inception Iteration

1)  **Vision and Business Case**    
Existing implementations are difficult to modify functionality, and to maintain. None are testable. Core capabilities are there but require regular intervention by a programmer that has expertise in VBA and has full understanding of the codebase in its entirety. There is no segregation of responsibility and certainly doesn’t embody SOLID programming principles.

*The Vision*: ensure maintenance and future changes are easily made by subsequent developers by applying a structured approach to development and employing SOLID principles. Implement testability.

*The Business Case*: the core functionality of each league is currently well understood and is well suited to the makeover to a new application. Implementation is accomplished by volunteers who have widely varying developer skills. By hosting the development on GitHub leveraging developers outside of the current stakeholders (AGL and FEGL) the end-product may gain wider support, extended life expectancy, and adherence to SOLID principles. A side benefit is helping less proficient coders mature developer skills and learn a little about golf in the process.

If the project is not undertaken and implemented, when the current developers are no longer able to support the current applications the leagues will have to struggle to function.

Initial implementation goal is to have essential functionality in place to support the AGL by the time that league begins play in the mid-summer of 2020. Full functionality supporting FEGL and AGL in the spring of 2021.

2)  **Use Case Model** - Initial Use Cases:    
The fundamental operations of all golf leagues have some basic needs which forms the basis for the Initial Use Cases. The following are to be fleshed out into either *Brief* or *Fully Dressed* formats

Roster and Team Management \*    
Scheduling of Rounds    
Scoring of Rounds/Handicapping \*    
Reporting of Round Results    
Budgeting of Fees and Awards    
Season Startup    
Season Closeout    
Course Management \*

\*Selected for first Elaboration

Most Actors, Goals, and Use Cases identified and Named (include in Glossary)    
Most Use cases written in *Brief* format.    
Selected Use Cases written in *Fully Dressed* format

3)  **Supplementary Specifications**    
Reporting    
    - Season Start    
    -----Teams/Players/Player Staring Handicap    
    -----Budget Management    
    ----------Payment of fees    
    ----------Award set up    
    -----Schedule of competitions    
    - During Season Play    
    ----Round Results    
    ----Next round information    
    ----Players/Handicaps    
    - Intermediate results (if any – e.g. Robin Winners)    
    - Season End    
    ----Budget Closeout        
    --------Monies In/Out    
    ----Season End Results    
Licensing    
    - Public (use normal public use license details)    
Documentation    
    - User    
    - Developer    
Golf course pricing model for rounds of play

4)  **Glossary**    
Established as a stand-alone document in GitHub to be updated as necessary.    
Need to determine the best document vehicle to support the Glossary so that it is easily maintained (alphabetical) and indexed.

5)  **Risk List & Risk Management Plan**    
TBD

6)  **Prototypes**    
Existing implementations to show how algorithms and user interfaces have been accomplished. Implementation of initial use cases constitute the foundational prototypes.

7)  **Iteration Plan**    
To be accomplished in 1<sup>st</sup> elaboration iteration:
<dl>
<dt>Flesh out each item in this list into separate documents into the formal structure outlined in AUAP pp104-119.</dt>
<dd>Decide what can be used from the current AGL and FEGL implementations</dd>
<dd>High level candidate architecture</dd>
<dd>Implement Select Use Cases</dd>
<dd>Identify the riskiest Use Cases to implement, fully dress them, and begin work on them</dd>
<dd>Agree on proposed subsequent elaboration time span</dd>
<dd>Proposed subsequent elaboration iteration time span:</dd>
<dt>Over 3 to 6 weeks:</dt>
<dd>Over a few days via email/other correspondence:</dd>
<dd>Agree on what is to be accomplished & assign tasks</dd>
<dd>Agree on schedule to accomplish tasks</dd>
<dt>Over the remainder of time in the elaboration:</dt>
<dd>Accomplish tasks according to agreement & evaluate results</dd>
<dd>Plan next elaboration iteration</dd>
</dl>

8)  **Phase Plan and Software Development Plan**   
Operational process for collaboration & approval of contributors in GitHub    
Tracking of open items   
Tools list   
Update and management of project Wiki

9)  **Development Case**   
TBD
