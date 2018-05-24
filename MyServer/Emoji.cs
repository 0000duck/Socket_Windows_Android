using MyChat.Properties;
using MyServer.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Test_Socket
{
    public class Emoji
    {

        private RichTextBox richTextBox1 = new RichTextBox();
        public Hashtable emotions = new Hashtable();

        #region سازنده ها
        public Hashtable Emotions { get => emotions; set => emotions = value; }

        public Emoji(Hashtable emoj)
        {
            this.Emotions = emoj;
        }

        public Emoji(RichTextBox richTextBox1, Hashtable emotions)
        {
            this.richTextBox1 = richTextBox1;
            this.Emotions = emotions;
        }

        public Emoji(RichTextBox richTextBox1)
        {
            this.richTextBox1 = richTextBox1;
        }

        public Emoji()
        {
        }
        #endregion

        public void CreateEmotions()
        {
            Emotions = new Hashtable(136);

            #region Radif 1
            Emotions.Add("[:)", value: Resources.emoji_1);
            Emotions.Add("[:(", Resources.emoji_2);
            Emotions.Add("[;)", Resources.emoji_3);

            Emotions.Add("[:D", Resources.emoji_4);
            Emotions.Add("[:d", Resources.emoji_5);
                                          
            Emotions.Add("[;;)", Resources.emoji_6);

            Emotions.Add("[:-DD", Resources.emoji_7);
            Emotions.Add("[:-dd", Resources.emoji_10);

            Emotions.Add("[>:-D<", Resources.emoji_9);
            Emotions.Add("[>:-d<", Resources.emoji_11);

            Emotions.Add("[:ty", Resources.emoji_12);

            Emotions.Add("[:x", Resources.emoji_13);
            Emotions.Add("[:X", Resources.emoji_14);

            Emotions.Add("[:TY", Resources.emoji_15);
            Emotions.Add("[:Ty", Resources.emoji_16);
            Emotions.Add("[:tY", Resources.emoji_17);

            #endregion

            #region Radif 2

            Emotions.Add("[:\">", Resources.emoji_18);
            Emotions.Add("[:P", Resources.emoji_19);
            Emotions.Add("[:*", Resources.emoji_20);
            Emotions.Add("[=((", Resources.emoji_21);
            Emotions.Add("[:O", Resources.emoji_22);
            Emotions.Add("[X(", Resources.emoji_23);
            Emotions.Add("[:->", Resources.emoji_24);
            Emotions.Add("[:B-)", Resources.emoji_25);
            Emotions.Add("[:SR", Resources.emoji_26);

            #endregion

            //#region Radif 3

            //Emotions.Add("[:-s", Resources.emoji_27);
            //Emotions.Add("[=D>", Resources.emoji_28);
            //Emotions.Add("[:C(", Resources.emoji_11);
            //Emotions.Add("[:-((", Resources.emoji_10);
            //Emotions.Add("[:H)", Resources.emoji_1);
            //Emotions.Add("[:h)", Resources.emoji_1);
            //Emotions.Add("[=))", Resources.emoji_1);
            //Emotions.Add(@"[\:-D/", Resources.emoji_1);
            //Emotions.Add("[:-PP", Resources.emoji_1);
            //Emotions.Add("[(-X", Resources.emoji_1);

            //#endregion

            //#region Radif 4

            //Emotions.Add("[:fight", Resources.R_04__1_);
            //Emotions.Add("[:ST", Resources.R_04__2_);
            //Emotions.Add("[#-O", Resources.R_04__3_);
            //Emotions.Add("[<:-P", Resources.R_04__4_);
            //Emotions.Add("[--X(", Resources.R_04__5_);
            //Emotions.Add("[\\;)", Resources.R_04__6_);
            //Emotions.Add("[#-ST", Resources.R_04__7_);
            //Emotions.Add("[:-)]", Resources.R_04__8_);
            //Emotions.Add("[:?", Resources.R_04__9_);

            //#endregion

            //#region Radif 5

            //Emotions.Add("[(-(", Resources.R_05__1_);
            //Emotions.Add("[#-BO", Resources.R_05__2_);
            //Emotions.Add("[8->", Resources.R_05__3_);
            //Emotions.Add("[:BZ", Resources.R_05__4_);
            //Emotions.Add("[(MU)", Resources.R_05__5_);
            //Emotions.Add("[:-DA", Resources.R_05__6_);
            //Emotions.Add("[:-RF", Resources.R_05__7_);
            //Emotions.Add("[::))", Resources.R_05__8_);
            //Emotions.Add("[:-*)", Resources.R_05__9_);

            //#endregion

            //#region Radif 6

            //Emotions.Add("[:-HK", Resources.R_06__1_);
            //Emotions.Add("[:-H", Resources.R_06__2_);
            //Emotions.Add("[:Help", Resources.R_06__3_);
            //Emotions.Add("[:-??", Resources.R_06__4_);
            //Emotions.Add("[:-FD", Resources.R_06__5_);
            //Emotions.Add("[(dance)", Resources.R_06__6_);
            //Emotions.Add("[#-HH", Resources.R_06__7_);
            //Emotions.Add("[:smoking", Resources.R_06__8_);
            //Emotions.Add("[~O)", Resources.R_06__9_);
            //#endregion

            //#region Radif 7

            //Emotions.Add("[#:RB", Resources.R_07__1_);
            //Emotions.Add("[:-BU", Resources.R_07__2_);
            //Emotions.Add("[:-FO", Resources.R_07__3_);
            //Emotions.Add("[:-)>-", Resources.R_07__4_);
            //Emotions.Add("[<3", Resources.R_07__5_);
            //Emotions.Add("[#-NS", Resources.R_07__6_);
            //Emotions.Add("[@};-", Resources.R_07__7_);
            //Emotions.Add("[:-OM", Resources.R_07__8_);
            //Emotions.Add("[:-FL", Resources.R_07__9_);

            //#endregion

            //#region Radif 8
            //Emotions.Add("[:-BD", Resources.R_08__1_);
            //Emotions.Add("[(:|", Resources.R_08__2_);
            //Emotions.Add("[:-{K", Resources.R_08__3_);
            //Emotions.Add("[:SC", Resources.R_08__4_);
            //Emotions.Add("[:SB", Resources.R_08__5_);
            //Emotions.Add("[:-FP", Resources.R_08__6_);
            //Emotions.Add("[:SG", Resources.R_08__7_);
            //Emotions.Add("[8-|", Resources.R_08__8_);
            //Emotions.Add("[:FP2", Resources.R_08__9_);

            //#endregion

            //#region Radif 9

            //Emotions.Add("[:HE", Resources.R_09__1_);
            //Emotions.Add("[:HO", Resources.R_09__2_);
            //Emotions.Add("[:-NF", Resources.R_09__3_);
            //Emotions.Add("[/:/", Resources.R_09__4_);
            //Emotions.Add("[:silly", Resources.R_09__5_);
            //Emotions.Add("[:yawn", Resources.R_09__6_);
            //Emotions.Add("[:-N", Resources.R_09__7_);
            //Emotions.Add("[:-Y", Resources.R_09__8_);
            //Emotions.Add("[:witch", Resources.R_09__9_);

            //#endregion

            //#region Radif 10
            ///*
            //#OM
            //(-?
            //:-"
            //(-[
            //=-D>>
            //(-SC
            //:bb
            //#)
            //:#Cake */

            //Emotions.Add("[#OM", Resources.R_10__1_);
            //Emotions.Add("[(-?", Resources.R_10__2_);
            //Emotions.Add("[:-\"", Resources.R_10__3_);
            //Emotions.Add("[(-[", Resources.R_10__4_);
            //Emotions.Add("[=-D>>", Resources.R_10__5_);
            //Emotions.Add("[(-SC", Resources.R_10__6_);
            //Emotions.Add("[:bb", Resources.R_10__7_);
            //Emotions.Add("[#)", Resources.R_10__8_);
            //Emotions.Add("[:#Cake", Resources.R_10__9_);
            //#endregion

            //#region Radif 11
            ///*
            //::DA
            //::PP
            //:CH
            //:BO
            //:SH
            //::PR
            //-:)_
            //:-K
            //:HR   */
            //Emotions.Add("[::DA", Resources.R_11__1_);
            //Emotions.Add("[::PP", Resources.R_11__2_);
            //Emotions.Add("[:CH", Resources.R_11__3_);
            //Emotions.Add("[:BO", Resources.R_11__4_);
            //Emotions.Add("[:SH", Resources.R_11__5_);
            //Emotions.Add("[::PR", Resources.R_11__6_);
            //Emotions.Add("[-:)_", Resources.R_11__7_);
            //Emotions.Add("[:-K", Resources.R_11__8_);
            //Emotions.Add("[:HR ", Resources.R_11__9_);

            //#endregion

            //#region Radif 12
            ///*
            //:CL
            //:BN
            //(manicure)
            //:RN
            //(cheering)
            //(computer)
            //(shy)
            //(guitarist)
            //(singing)
            //*/
            //Emotions.Add("[:CL", Resources.R_12__1_);
            //Emotions.Add("[:BN", Resources.R_12__2_);
            //Emotions.Add("[(manicure)", Resources.R_12__3_);
            //Emotions.Add("[:RN", Resources.R_12__4_);
            //Emotions.Add("[(cheering)", Resources.R_12__5_);
            //Emotions.Add("[(computer)", Resources.R_12__6_);
            //Emotions.Add("[(shy)", Resources.R_12__7_);
            //Emotions.Add("[(guitarist)", Resources.R_12__8_);
            //Emotions.Add("[(singing)", Resources.R_12__9_);

            //#endregion

            //#region Radif 13
            ///*
            //:bdance
            //:bday
            //(xmas)
            //(clap)
            //:hbd
            //:hny
            //(chl)
            //:swim
            //(xsnow)
            //*/
            //Emotions.Add("[:bdance", Resources.R_13__1_);
            //Emotions.Add("[:bday", Resources.R_13__2_);
            //Emotions.Add("[(xmas)", Resources.R_13__3_);
            //Emotions.Add("[(clap)", Resources.R_13__4_);
            //Emotions.Add("[:hbd", Resources.R_13__5_);
            //Emotions.Add("[:hny", Resources.R_13__6_);
            //Emotions.Add("[(chl)", Resources.R_13__7_);
            //Emotions.Add("[:swim", Resources.R_13__8_);
            //Emotions.Add("[(xsnow)", Resources.R_13__9_);

            //#endregion

            //#region Radif 14
            ///*
            //(mario)
            //(cook)
            //(gig)
            //(anni)
            //(h.val)
            //(bday)
            //(rainbow)
            //(hit)
            //(head)
            //*/
            //Emotions.Add("[(mario)", Resources.R_14__1_);
            //Emotions.Add("[(cook)", Resources.R_14__2_);
            //Emotions.Add("[(gig)", Resources.R_14__3_);
            //Emotions.Add("[(anni)", Resources.R_14__4_);
            //Emotions.Add("[(h.val)", Resources.R_14__5_);
            //Emotions.Add("[(bday)", Resources.R_14__6_);
            //Emotions.Add("[(rainbow)", Resources.R_14__7_);
            //Emotions.Add("[(hit)", Resources.R_14__8_);
            //Emotions.Add("[(head)", Resources.R_14__9_);

            //#endregion

            //#region Radif 15
            ///*
            //(wow)
            //(lovebird)
            //(b.day)
            //(lol)
            //(ilu)
            //(cmptr)
            //(pengu)
            //(val)
            //(kiss)
            //*/
            //Emotions.Add("[(wow)", Resources.R_15__1_);
            //Emotions.Add("[(lovebird)", Resources.R_15__2_);
            //Emotions.Add("[(b.day)", Resources.R_15__3_);
            //Emotions.Add("[(lol)", Resources.R_15__4_);
            //Emotions.Add("[(ilu)", Resources.R_15__5_);
            //Emotions.Add("[(cmptr)", Resources.R_15__6_);
            //Emotions.Add("[(pengu)", Resources.R_15__7_);
            //Emotions.Add("[(val)", Resources.R_15__8_);
            //Emotions.Add("[(kiss)", Resources.R_15__9_);

            //#endregion

        }

        public void AddEmotions()
        {
            foreach (string emote in Emotions.Keys)
            {
                try
                {
                    while (richTextBox1.Text.Contains(emote))
                    {
                        int ind = richTextBox1.Text.IndexOf(emote);
                        richTextBox1.Select(ind, emote.Length);
                        Clipboard.SetImage((Image)Emotions[emote]);
                        richTextBox1.Paste();
                    }

                }
                catch (Exception /*ex*/)
                {

                    //   MessageBox.Show(ex.ToString());
                }
            }
        }

        public void FontChange(RichTextBox richTextBox)
        {
            FontDialog fpanel = new FontDialog
            {
                ShowColor = true
            };
            richTextBox1.Font = fpanel.Font;
            richTextBox1.ForeColor = fpanel.Color;

            if (fpanel.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox1.Font = fpanel.Font;
                richTextBox1.ForeColor = fpanel.Color;
            }
        }




        ImageList MyimageList = new ImageList();
        ListViewItem MyListViewItem = new ListViewItem();
        List<string> MyListText = new List<string>();

        public void FillListView(ListView MylistView)
        {
            MylistView.Columns.Add(text: "Emoji", width: 105);
            MylistView.Columns.Add(text: "Text", width: 105);

            MylistView.GridLines = true;
            MylistView.View = View.Details;

            CreateEmotions();
            AddEmotions();

            MylistView.SmallImageList = MyimageList;

            foreach (var item in emotions.Keys)
            {
                MyListText.Add(item.ToString());
            }
            foreach (var item in MyListText)
            {
                MyListViewItem.SubItems.Add(item);

            }
            foreach (Image Aks in emotions.Values)
            {
                MyimageList.Images.Add(Aks);
            }
            for (int i = 0; i < MyimageList.Images.Count; ++i)
            {

                ListViewItem item = new ListViewItem { ImageIndex = i };
                MylistView.Items.Add(item).SubItems.Add(MyListText[i]);

            }

        }

        public int FindIndex(ListView MylistView)
        {
            AddEmotions();
            CreateEmotions();

            if (MylistView.FocusedItem == null) return 0;

            int SelectedIndex = MylistView.FocusedItem.Index;

            foreach (var item in emotions.Keys)
            {
                return int.Parse(SelectedIndex.ToString());
            }
            return 0;
        }
        public void EditListview(ListView MylistView, out string OldValue, string NewValue)
        {
            if (MylistView.SelectedItems.Count == 0) { OldValue = null; return; }

            ListViewItem item = MylistView.SelectedItems[0];

            OldValue = item.SubItems[1].Text;
            if (NewValue != string.Empty)
            {
                MylistView.SelectedItems[0].SubItems[1].Text = NewValue;
            }
            else
            {
                ListViewItem item2 = MylistView.SelectedItems[0];
                OldValue = item2.SubItems[1].Text;
            }
        }
    }

}
