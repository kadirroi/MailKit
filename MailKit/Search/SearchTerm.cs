﻿//
// SearchTerm.cs
//
// Author: Jeffrey Stedfast <jeff@xamarin.com>
//
// Copyright (c) 2013-2015 Xamarin Inc. (www.xamarin.com)
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//

namespace MailKit.Search {
	enum SearchTerm {
		All,
		And,
		Answered,
		BccContains,
		BodyContains,
		CcContains,
		Deleted,
		DeliveredAfter,
		DeliveredBefore,
		DeliveredOn,
		Draft,
		Flagged,
		FromContains,
		Fuzzy,
		HeaderContains,
		Keyword,
		LargerThan,
		MessageContains,
		ModSeq,
		New,
		Not,
		NotAnswered,
		NotDeleted,
		NotDraft,
		NotFlagged,
		NotKeyword,
		NotRecent,
		NotSeen,
		Older,
		Or,
		Recent,
		Seen,
		SentAfter,
		SentBefore,
		SentOn,
		SmallerThan,
		SubjectContains,
		ToContains,
		Uid,
		Younger,

		// GMail SEARCH extensions
		GMailMessageId,
		GMailThreadId,
		GMailLabels,
		GMailRaw,
	}
}
