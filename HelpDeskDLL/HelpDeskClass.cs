/* Title:           Help Desk Class
 * Date:            7-9-20
 * Author:          Terry Holmes
 * 
 * Description:     This is the Help Desk Class File */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using HelpDeskDLL.HelpDeskTicketDocumentationDataSetTableAdapters;
using HelpDeskDLL.HelpDeskTicketsDataSetTableAdapters;
using NewEventLogDLL;

namespace HelpDeskDLL
{
    public class HelpDeskClass
    {
        EventLogClass TheEventLogClass = new EventLogClass();

        HelpDeskTicketsDataSet aHelpDeskTicketsDataSet;
        HelpDeskTicketsDataSetTableAdapters.helpdeskticketsTableAdapter aHelpDeskTicketsTableAdapter;

        InsertHelpDeskTicketEntryTableAdapters.QueriesTableAdapter aInsertHelpDeskTicketTableAdapter;

        UpdateHelpDeskTicketStatusEntryTableAdapters.QueriesTableAdapter aUpdateHelpDeskTicketStatusTableAdapter;

        FindHelpDeskTicketbyTicketMatchDateDataSet aFindHelpDeskTicketByTicketDateMatchDataSet;
        FindHelpDeskTicketbyTicketMatchDateDataSetTableAdapters.FindHelpDeskTicketByTicketDateMatchTableAdapter aFindHelpDeskTicketByTicketDateMatchTableAdapter;

        FindHelpDeskTicketsByDateRangeDataSet aFindHelpDeskTicketsByDateRangeDataSet;
        FindHelpDeskTicketsByDateRangeDataSetTableAdapters.FindHelpDeskTicketsByDateRangeTableAdapter aFindHelpDeskTicketsByDateRangeTableAdapter;

        FindHelpDeskTicketsByTicketIDDataSet aFindHelpDeskTicketsByTicketIDDateSet;
        FindHelpDeskTicketsByTicketIDDataSetTableAdapters.FindHelpDeskTicketsByTicketIDTableAdapter aFindHelpDeskTicketsByTicketIDTableAdapter;

        HelpDeskTicketDocumentationDataSet aHelpDeskTicketDocumentationDataSet;
        HelpDeskTicketDocumentationDataSetTableAdapters.helpdeskticketdocumentationTableAdapter aHelpDeskTicketDocumentationTableAdapter;

        InsertHelpDeskTicketDocumentationEntryTableAdapters.QueriesTableAdapter aInsertHelpDeskTicketDocumentationTableAdapter;

        FindHelpDeskTicketDocumentationByTicketIDDataSet aFindHelpDeskTicketDocumentationByTicketIDDataSet;
        FindHelpDeskTicketDocumentationByTicketIDDataSetTableAdapters.FindHelpDeskTicketDocumentationByTicketIDTableAdapter aFindHelpDeskTicketDocumentationbyTicketIDTableAdapter;

        HelpDeskTicketUpdateDataSet aHelpDeskTicketUpdateDataSet;
        HelpDeskTicketUpdateDataSetTableAdapters.helpdeskticketupdateTableAdapter aHelpDeskTicketUpdateTableAdapter;

        InsertHelpDeskTicketUpdateEntryTableAdapters.QueriesTableAdapter aInsertHelpDeskTicketUpdateTableAdapter;

        FindHelpDeskTicketUpdatesByTicketIDDataSet aFindHelpDeskTicketUpdatesByTicketIDDataSet;
        FindHelpDeskTicketUpdatesByTicketIDDataSetTableAdapters.FindHelpDeskTicketUpdatesByTicketIDTableAdapter aFindHelpDeskTicketUpdatesByTicketIDTableAdapter;

        HelpDeskProblemTypeDataSet aHelpDeskProblemTypeDataSet;
        HelpDeskProblemTypeDataSetTableAdapters.helpdeskproblemtypeTableAdapter aHelpDeskProblemTypeTableAdapter;

        InsertHelpDeskProblemTypeEntryTableAdapters.QueriesTableAdapter aInsertHelpDeskProblemTypeTableAdapter;

        FindSortedHelpDeskProblemTypeDataSet aFindSortedHelpDeskProblemTypeDataSet;
        FindSortedHelpDeskProblemTypeDataSetTableAdapters.FindSortedHelpDeskProblemTypeTableAdapter aFindSortedHelpDeskProblemTypeTableAdpater;

        FindHelpDeskProblemTypeByProblemTyepIDDataSet aFindHelpDeskProblemtypeByProblemTypeIDDataSet;
        FindHelpDeskProblemTypeByProblemTyepIDDataSetTableAdapters.FindHelpDeskProblemTypeByProblemTypeIDTableAdapter aFindHelpDeskProblemTypeByProblemTypeIDTableAdapter;

        FindHelpDeskProblemTypeByProblemTypeDataSet aFindHelpDeskProblemTypeByProblemTypeDataSet;
        FindHelpDeskProblemTypeByProblemTypeDataSetTableAdapters.FindHelpDeskProblemTypeByProblemTypeTableAdapter aFindHelpDeskProblemTypeByProblemTypeTableAdapter;

        HelpDeskTicketAssignmentDataSet aHelpDeskTicketAssignmentDataSet;
        HelpDeskTicketAssignmentDataSetTableAdapters.helpdeskticketassignmentTableAdapter aHelpDeskTicketAssignmentTableAdapter;

        InsertHelpDeskTicketAssignmentTableAdapters.QueriesTableAdapter aInsertHelpDeskTicketAssignmentTableAdapter;

        UpdateHelpDeskTicketCurrentAssignmentEntryTableAdapters.QueriesTableAdapter aUpdateHelpDeskTicketCurrentAssignmentTableAdapter;

        FindHelpDeskTicketCurrentAssignmentDataSet aFindHelpDeskTicketCurrentAssignmentDataSet;
        FindHelpDeskTicketCurrentAssignmentDataSetTableAdapters.FindHelpDeskTicketCurrentAssignmentTableAdapter aFindHelpDeskTicketCurrentAssignmentTableAdapter;

        FindHelpDeskTicketAssignmentsDataSet aFindHelpDeskTicketAssignmentsDataSet;
        FindHelpDeskTicketAssignmentsDataSetTableAdapters.FindHelpDeskTicketAssignmentsTableAdapter aFindHelpDeskTicketAssignmentsTableAdapter;

        FindHelpDeskTicketUpdatesByDateRangeDataSet aFindHelpDeskTicketUpdatesByDateRangeDataSet;
        FindHelpDeskTicketUpdatesByDateRangeDataSetTableAdapters.FindHelpTicketUpdatesByDateRangeTableAdapter aFindHelpDeskTicketUpdatesByDateRangeTableAdapter;

        FindOpenHelpDeskTicketsDataSet aFindOpenHelpDeskTicketsDataSet;
        FindOpenHelpDeskTicketsDataSetTableAdapters.FindOpenHelpDeskTicketsTableAdapter aFindOpenHelpDeskTicketsTableAdapter;

        FindHelpDeskTicketsNotAssignedByTicketIDDataSet aFindHelpDeskTicketsNotAssignedByTicketIDDataSet;
        FindHelpDeskTicketsNotAssignedByTicketIDDataSetTableAdapters.FindHelpDeskTicketsNotAssignedByTicketIDTableAdapter aFindHelpDeskTicketsNotAssignedByTicketIDTableAdapter;

        public FindHelpDeskTicketsNotAssignedByTicketIDDataSet FindHelpDeskTicketsNotAssignedByTicketID(int intTicketID)
        {
            try
            {
                aFindHelpDeskTicketsNotAssignedByTicketIDDataSet = new FindHelpDeskTicketsNotAssignedByTicketIDDataSet();
                aFindHelpDeskTicketsNotAssignedByTicketIDTableAdapter = new FindHelpDeskTicketsNotAssignedByTicketIDDataSetTableAdapters.FindHelpDeskTicketsNotAssignedByTicketIDTableAdapter();
                aFindHelpDeskTicketsNotAssignedByTicketIDTableAdapter.Fill(aFindHelpDeskTicketsNotAssignedByTicketIDDataSet.FindHelpDeskTicketsNotAssignedByTicketID, intTicketID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Help Desk Class // Find Help Desk Tickets Not Assigned By Ticket ID " + Ex.Message);
            }

            return aFindHelpDeskTicketsNotAssignedByTicketIDDataSet;
        }
        public FindOpenHelpDeskTicketsDataSet FindOpenHelpDeskTickets()
        {
            try
            {
                aFindOpenHelpDeskTicketsDataSet = new FindOpenHelpDeskTicketsDataSet();
                aFindOpenHelpDeskTicketsTableAdapter = new FindOpenHelpDeskTicketsDataSetTableAdapters.FindOpenHelpDeskTicketsTableAdapter();
                aFindOpenHelpDeskTicketsTableAdapter.Fill(aFindOpenHelpDeskTicketsDataSet.FindOpenHelpDeskTickets);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Help Desk Class // Find Open Help Desk Tickets " + Ex.Message);
            }

            return aFindOpenHelpDeskTicketsDataSet;
        }
        public FindHelpDeskTicketUpdatesByDateRangeDataSet FindHelpDeskTicketUpdates(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindHelpDeskTicketUpdatesByDateRangeDataSet = new FindHelpDeskTicketUpdatesByDateRangeDataSet();
                aFindHelpDeskTicketUpdatesByDateRangeTableAdapter = new FindHelpDeskTicketUpdatesByDateRangeDataSetTableAdapters.FindHelpTicketUpdatesByDateRangeTableAdapter();
                aFindHelpDeskTicketUpdatesByDateRangeTableAdapter.Fill(aFindHelpDeskTicketUpdatesByDateRangeDataSet.FindHelpTicketUpdatesByDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Help Desk Class // Find Help Desk Ticket Updates " + Ex.Message);
            }

            return aFindHelpDeskTicketUpdatesByDateRangeDataSet;
        }
        public FindHelpDeskTicketAssignmentsDataSet FindHelpDeskTicketAssignments(int intTicketID)
        {
            try
            {
                aFindHelpDeskTicketAssignmentsDataSet = new FindHelpDeskTicketAssignmentsDataSet();
                aFindHelpDeskTicketAssignmentsTableAdapter = new FindHelpDeskTicketAssignmentsDataSetTableAdapters.FindHelpDeskTicketAssignmentsTableAdapter();
                aFindHelpDeskTicketAssignmentsTableAdapter.Fill(aFindHelpDeskTicketAssignmentsDataSet.FindHelpDeskTicketAssignments, intTicketID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Help Desk Class // Find Help Desk Ticket Assignments " + Ex.Message);
            }

            return aFindHelpDeskTicketAssignmentsDataSet;
        }
        public FindHelpDeskTicketCurrentAssignmentDataSet FindHelpDeskTicketCurrentAssignment(int intTicketID)
        {
            try
            {
                aFindHelpDeskTicketCurrentAssignmentDataSet = new FindHelpDeskTicketCurrentAssignmentDataSet();
                aFindHelpDeskTicketCurrentAssignmentTableAdapter = new FindHelpDeskTicketCurrentAssignmentDataSetTableAdapters.FindHelpDeskTicketCurrentAssignmentTableAdapter();
                aFindHelpDeskTicketCurrentAssignmentTableAdapter.Fill(aFindHelpDeskTicketCurrentAssignmentDataSet.FindHelpDeskTicketCurrentAssignment, intTicketID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Help Desk Class // Find Help Desk Ticket Current Assignment " + Ex.Message);
            }

            return aFindHelpDeskTicketCurrentAssignmentDataSet;
        }
        public bool UpdateHelpDeskTicketCurrrentAssignment(int intTransactionID, bool blnCurrentAssignment)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateHelpDeskTicketCurrentAssignmentTableAdapter = new UpdateHelpDeskTicketCurrentAssignmentEntryTableAdapters.QueriesTableAdapter();
                aUpdateHelpDeskTicketCurrentAssignmentTableAdapter.UpdateHelpDeskTicketCurrentAssignment(intTransactionID, blnCurrentAssignment);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Help Desk Class // Update Help Desk Ticket Current Assignment " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertHelpDeskTicketAssignment(int intTicketID, int intEmployeeID)
        {
            bool blnFatalError = false;

            try
            {
                aInsertHelpDeskTicketAssignmentTableAdapter = new InsertHelpDeskTicketAssignmentTableAdapters.QueriesTableAdapter();
                aInsertHelpDeskTicketAssignmentTableAdapter.InsertHelpDeskTicketAssignment(intTicketID, intEmployeeID, DateTime.Now);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Help Desk Class // Insert Help Desk Ticket Assignment " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public HelpDeskTicketAssignmentDataSet GetHelpDeskTicketAssignmentInfo()
        {
            try
            {
                aHelpDeskTicketAssignmentDataSet = new HelpDeskTicketAssignmentDataSet();
                aHelpDeskTicketAssignmentTableAdapter = new HelpDeskTicketAssignmentDataSetTableAdapters.helpdeskticketassignmentTableAdapter();
                aHelpDeskTicketAssignmentTableAdapter.Fill(aHelpDeskTicketAssignmentDataSet.helpdeskticketassignment);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Help Desk Class // Get Help Desk Ticket Assignment Info " + Ex.Message);
            }

            return aHelpDeskTicketAssignmentDataSet;
        }
        public void UpdateHelpDeskTicketAssignmentDB(HelpDeskTicketAssignmentDataSet aHelpDeskTicketAssignmentDataSet)
        {
            try
            {
                aHelpDeskTicketAssignmentTableAdapter = new HelpDeskTicketAssignmentDataSetTableAdapters.helpdeskticketassignmentTableAdapter();
                aHelpDeskTicketAssignmentTableAdapter.Update(aHelpDeskTicketAssignmentDataSet.helpdeskticketassignment);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Help Desk Class // Update Help Desk Ticket Assignment DB " + Ex.Message);
            }
        }
        public FindHelpDeskProblemTypeByProblemTypeDataSet FindHelpDeskProblemTypeByProblemType(string strProblemType)
        {
            try
            {
                aFindHelpDeskProblemTypeByProblemTypeDataSet = new FindHelpDeskProblemTypeByProblemTypeDataSet();
                aFindHelpDeskProblemTypeByProblemTypeTableAdapter = new FindHelpDeskProblemTypeByProblemTypeDataSetTableAdapters.FindHelpDeskProblemTypeByProblemTypeTableAdapter();
                aFindHelpDeskProblemTypeByProblemTypeTableAdapter.Fill(aFindHelpDeskProblemTypeByProblemTypeDataSet.FindHelpDeskProblemTypeByProblemType, strProblemType);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Help Desk Class // Find Help Desk Problem Type By Problem Type " + Ex.Message);
            }

            return aFindHelpDeskProblemTypeByProblemTypeDataSet;
        }
        public FindHelpDeskProblemTypeByProblemTyepIDDataSet FindHelpDeskProblemTypeByProblemTypeID(int intProblemID)
        {
            try
            {
                aFindHelpDeskProblemtypeByProblemTypeIDDataSet = new FindHelpDeskProblemTypeByProblemTyepIDDataSet();
                aFindHelpDeskProblemTypeByProblemTypeIDTableAdapter = new FindHelpDeskProblemTypeByProblemTyepIDDataSetTableAdapters.FindHelpDeskProblemTypeByProblemTypeIDTableAdapter();
                aFindHelpDeskProblemTypeByProblemTypeIDTableAdapter.Fill(aFindHelpDeskProblemtypeByProblemTypeIDDataSet.FindHelpDeskProblemTypeByProblemTypeID, intProblemID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Help Desk Class // Find Help Desk Problem Type By Problem Type ID " + Ex.Message);
            }

            return aFindHelpDeskProblemtypeByProblemTypeIDDataSet;
        }
        public FindSortedHelpDeskProblemTypeDataSet FindSortedHelpDeskProblemType()
        {
            try
            {
                aFindSortedHelpDeskProblemTypeDataSet = new FindSortedHelpDeskProblemTypeDataSet();
                aFindSortedHelpDeskProblemTypeTableAdpater = new FindSortedHelpDeskProblemTypeDataSetTableAdapters.FindSortedHelpDeskProblemTypeTableAdapter();
                aFindSortedHelpDeskProblemTypeTableAdpater.Fill(aFindSortedHelpDeskProblemTypeDataSet.FindSortedHelpDeskProblemType);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Help Desk Class // Find Sorted Help Desk Problem Type " + Ex.Message);
            }

            return aFindSortedHelpDeskProblemTypeDataSet;
        }
        public bool InsertHelpDeskProblemType(string strProblemType)
        {
            bool blnFatalError = false;

            try
            {
                aInsertHelpDeskProblemTypeTableAdapter = new InsertHelpDeskProblemTypeEntryTableAdapters.QueriesTableAdapter();
                aInsertHelpDeskProblemTypeTableAdapter.InsertHelpDeskProblemType(strProblemType);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Help Desk Class // Insert Help Desk Problem Type " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public HelpDeskProblemTypeDataSet GetHelpDeskProblemTypeInfo()
        {
            try
            {
                aHelpDeskProblemTypeDataSet = new HelpDeskProblemTypeDataSet();
                aHelpDeskProblemTypeTableAdapter = new HelpDeskProblemTypeDataSetTableAdapters.helpdeskproblemtypeTableAdapter();
                aHelpDeskProblemTypeTableAdapter.Fill(aHelpDeskProblemTypeDataSet.helpdeskproblemtype);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Help Desk Class // Get Help Desk Problem Type Info " + Ex.Message);
            }

            return aHelpDeskProblemTypeDataSet;
        }
        public void UpdateHelpDeskProblemType(HelpDeskProblemTypeDataSet aHelpDeskProblemTypeDataSet)
        {
            try
            {
                aHelpDeskProblemTypeTableAdapter = new HelpDeskProblemTypeDataSetTableAdapters.helpdeskproblemtypeTableAdapter();
                aHelpDeskProblemTypeTableAdapter.Update(aHelpDeskProblemTypeDataSet.helpdeskproblemtype);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Help Desk Class // Update Help Desk Problem Type DB " + Ex.Message);
            }
        }
        public FindHelpDeskTicketUpdatesByTicketIDDataSet FindHelpDeskTicketUpdatesByTicketID(int intTicketID)
        {
            try
            {
                aFindHelpDeskTicketUpdatesByTicketIDDataSet = new FindHelpDeskTicketUpdatesByTicketIDDataSet();
                aFindHelpDeskTicketUpdatesByTicketIDTableAdapter = new FindHelpDeskTicketUpdatesByTicketIDDataSetTableAdapters.FindHelpDeskTicketUpdatesByTicketIDTableAdapter();
                aFindHelpDeskTicketUpdatesByTicketIDTableAdapter.Fill(aFindHelpDeskTicketUpdatesByTicketIDDataSet.FindHelpDeskTicketUpdatesByTicketID, intTicketID);
            }
            catch (Exception ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Help Desk Class // Find Help Desk Ticket Updates By Ticket ID " + ex.Message);
            }

            return aFindHelpDeskTicketUpdatesByTicketIDDataSet;
        }
        public bool InsertHelpDeskTicketUpdate(int intTicketID, int intEmployeeID, string strUpdateNotes)
        {
            bool blnFatalError = false;

            try
            {
                aInsertHelpDeskTicketUpdateTableAdapter = new InsertHelpDeskTicketUpdateEntryTableAdapters.QueriesTableAdapter();
                aInsertHelpDeskTicketUpdateTableAdapter.InsertHelpDeskTicketUpdate(intTicketID, intEmployeeID, DateTime.Now, strUpdateNotes);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Help Desk Class // Insert Help Desk Ticket Update " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public HelpDeskTicketUpdateDataSet GetHelpDeskTicketUpdateInfo()
        {
            try
            {
                aHelpDeskTicketUpdateDataSet = new HelpDeskTicketUpdateDataSet();
                aHelpDeskTicketUpdateTableAdapter = new HelpDeskTicketUpdateDataSetTableAdapters.helpdeskticketupdateTableAdapter();
                aHelpDeskTicketUpdateTableAdapter.Fill(aHelpDeskTicketUpdateDataSet.helpdeskticketupdate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Help Desk Class // Get Help Desk Ticket Update Info " + Ex.Message);
            }

            return aHelpDeskTicketUpdateDataSet;
        }
        public void UpdateHelpDeskTicketUpdateDB(HelpDeskTicketUpdateDataSet aHelpDeskTicketUpdateDataSet)
        {
            try
            {
                aHelpDeskTicketUpdateTableAdapter = new HelpDeskTicketUpdateDataSetTableAdapters.helpdeskticketupdateTableAdapter();
                aHelpDeskTicketUpdateTableAdapter.Update(aHelpDeskTicketUpdateDataSet.helpdeskticketupdate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Help Desk Class // Update Help Desk Ticket Update DB " + Ex.Message);
            }
        }
        public FindHelpDeskTicketDocumentationByTicketIDDataSet FindHelpDeskTicketDocumentationByTicketID(int intTicketID)
        {
            try
            {
                aFindHelpDeskTicketDocumentationByTicketIDDataSet = new FindHelpDeskTicketDocumentationByTicketIDDataSet();
                aFindHelpDeskTicketDocumentationbyTicketIDTableAdapter = new FindHelpDeskTicketDocumentationByTicketIDDataSetTableAdapters.FindHelpDeskTicketDocumentationByTicketIDTableAdapter();
                aFindHelpDeskTicketDocumentationbyTicketIDTableAdapter.Fill(aFindHelpDeskTicketDocumentationByTicketIDDataSet.FindHelpDeskTicketDocumentationByTicketID, intTicketID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Help Desk Class // Find Help Desk Ticket Documentation By Ticket ID " + Ex.Message);
            }

            return aFindHelpDeskTicketDocumentationByTicketIDDataSet;
        }
        public bool InsertHelpDeskTicketDocumentation(int intTicketID, DateTime datTransactionDate, string strDocumentPath)
        {
            bool blnFatalError = false;

            try
            {
                aInsertHelpDeskTicketDocumentationTableAdapter = new InsertHelpDeskTicketDocumentationEntryTableAdapters.QueriesTableAdapter();
                aInsertHelpDeskTicketDocumentationTableAdapter.InsertHelpDeskTicketDocumentation(intTicketID, datTransactionDate, strDocumentPath);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Help Desk Class // Insert Help Desk Ticket Documentation " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public HelpDeskTicketDocumentationDataSet GetHelpDeskTicketDocumentationInfo()
        {
            try
            {
                aHelpDeskTicketDocumentationDataSet = new HelpDeskTicketDocumentationDataSet();
                aHelpDeskTicketDocumentationTableAdapter = new helpdeskticketdocumentationTableAdapter();
                aHelpDeskTicketDocumentationTableAdapter.Fill(aHelpDeskTicketDocumentationDataSet.helpdeskticketdocumentation);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Help Desk Class // Get Help Desk Ticket Documentation Info " + Ex.Message);
            }

            return aHelpDeskTicketDocumentationDataSet;
        }
        public void UpdateHelpDeskTicketDocumentationDB(HelpDeskTicketDocumentationDataSet aHelpDeskTicketDocumentationDataSet)
        {
            try
            {
                aHelpDeskTicketDocumentationTableAdapter = new helpdeskticketdocumentationTableAdapter();
                aHelpDeskTicketDocumentationTableAdapter.Update(aHelpDeskTicketDocumentationDataSet.helpdeskticketdocumentation);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Help Desk Class // Update Help Desk Ticket Documentation DB " + Ex.Message);
            }
        }
        public FindHelpDeskTicketsByTicketIDDataSet FindHelpDeskTicketByTicketID(int intTicketID)
        {
            try
            {
                aFindHelpDeskTicketsByTicketIDDateSet = new FindHelpDeskTicketsByTicketIDDataSet();
                aFindHelpDeskTicketsByTicketIDTableAdapter = new FindHelpDeskTicketsByTicketIDDataSetTableAdapters.FindHelpDeskTicketsByTicketIDTableAdapter();
                aFindHelpDeskTicketsByTicketIDTableAdapter.Fill(aFindHelpDeskTicketsByTicketIDDateSet.FindHelpDeskTicketsByTicketID, intTicketID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Help Desk Class // Find Help Desk Tickets By Ticket ID " + Ex.Message);
            }

            return aFindHelpDeskTicketsByTicketIDDateSet;
        }
        public FindHelpDeskTicketsByDateRangeDataSet FindHelpDeskTicketsByDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindHelpDeskTicketsByDateRangeDataSet = new FindHelpDeskTicketsByDateRangeDataSet();
                aFindHelpDeskTicketsByDateRangeTableAdapter = new FindHelpDeskTicketsByDateRangeDataSetTableAdapters.FindHelpDeskTicketsByDateRangeTableAdapter();
                aFindHelpDeskTicketsByDateRangeTableAdapter.Fill(aFindHelpDeskTicketsByDateRangeDataSet.FindHelpDeskTicketsByDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Help Desk Class // Find Help Desk Tickets By Date Range " + Ex.Message);
            }

            return aFindHelpDeskTicketsByDateRangeDataSet;
        }
        public FindHelpDeskTicketbyTicketMatchDateDataSet FindHelpDeskTicketByTicketDateMatch(DateTime datTicketDate)
        {
            try
            {
                aFindHelpDeskTicketByTicketDateMatchDataSet = new FindHelpDeskTicketbyTicketMatchDateDataSet();
                aFindHelpDeskTicketByTicketDateMatchTableAdapter = new FindHelpDeskTicketbyTicketMatchDateDataSetTableAdapters.FindHelpDeskTicketByTicketDateMatchTableAdapter();
                aFindHelpDeskTicketByTicketDateMatchTableAdapter.Fill(aFindHelpDeskTicketByTicketDateMatchDataSet.FindHelpDeskTicketByTicketDateMatch, datTicketDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Help Desk Class // Find Help Desk Ticket By Ticket Date Match " + Ex.Message);
            }

            return aFindHelpDeskTicketByTicketDateMatchDataSet;
        }
        public bool UpdateHelpDeskTicketStatus(int intTicketID, string strTicketStatus)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateHelpDeskTicketStatusTableAdapter = new UpdateHelpDeskTicketStatusEntryTableAdapters.QueriesTableAdapter();
                aUpdateHelpDeskTicketStatusTableAdapter.UpdateHelpDeskTicketStatus(intTicketID, strTicketStatus);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Help Desk Class // Update Help Desk Ticket Status " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertHelpDeskTicket(DateTime datTicketDate, string strComputerName, string strUserName, string strIPAddress, int intWarehouseID, int intProblemTypeID, string strReportedProblem, int intEmployee)
        {
            bool blnFatalError = false;

            try
            {
                aInsertHelpDeskTicketTableAdapter = new InsertHelpDeskTicketEntryTableAdapters.QueriesTableAdapter();
                aInsertHelpDeskTicketTableAdapter.InsertHelpDeskTicket(datTicketDate, strComputerName, strUserName, strIPAddress, intWarehouseID, intProblemTypeID, strReportedProblem, "OPEN", intEmployee);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Help Desk Class // Insert Help Desk Ticket " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public HelpDeskTicketsDataSet GetHelpDeskTicketsInfo()
        {
            try
            {
                aHelpDeskTicketsDataSet = new HelpDeskTicketsDataSet();
                aHelpDeskTicketsTableAdapter = new helpdeskticketsTableAdapter();
                aHelpDeskTicketsTableAdapter.Fill(aHelpDeskTicketsDataSet.helpdesktickets);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Help Desk Class // Get Help Desk Tickets Info " + Ex.Message);
            }

            return aHelpDeskTicketsDataSet;
        }
        public void UpdateHelpDeskTicketsDB(HelpDeskTicketsDataSet aHelpDeskTicketsDataSet)
        {
            try
            {
                aHelpDeskTicketsTableAdapter = new helpdeskticketsTableAdapter();
                aHelpDeskTicketsTableAdapter.Update(aHelpDeskTicketsDataSet.helpdesktickets);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Help Desk Class // Get Help Desk Tickets Info " + Ex.Message);
            }
        }
    }
}
