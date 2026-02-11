using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000089 RID: 137
	public class RegexRunner : Object
	{
		// Token: 0x06000A37 RID: 2615 RVA: 0x00043468 File Offset: 0x00041668
		// Note: this type is marked as 'beforefieldinit'.
		static RegexRunner()
		{
			Il2CppClassPointerStore<RegexRunner>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexRunner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr);
			RegexRunner.NativeFieldInfoPtr_runtextbeg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runtextbeg");
			RegexRunner.NativeFieldInfoPtr_runtextend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runtextend");
			RegexRunner.NativeFieldInfoPtr_runtextstart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runtextstart");
			RegexRunner.NativeFieldInfoPtr_runtext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runtext");
			RegexRunner.NativeFieldInfoPtr_runtextpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runtextpos");
			RegexRunner.NativeFieldInfoPtr_runtrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runtrack");
			RegexRunner.NativeFieldInfoPtr_runtrackpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runtrackpos");
			RegexRunner.NativeFieldInfoPtr_runstack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runstack");
			RegexRunner.NativeFieldInfoPtr_runstackpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runstackpos");
			RegexRunner.NativeFieldInfoPtr_runcrawl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runcrawl");
			RegexRunner.NativeFieldInfoPtr_runcrawlpos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runcrawlpos");
			RegexRunner.NativeFieldInfoPtr_runtrackcount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runtrackcount");
			RegexRunner.NativeFieldInfoPtr_runmatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runmatch");
			RegexRunner.NativeFieldInfoPtr_runregex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "runregex");
			RegexRunner.NativeFieldInfoPtr__timeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "_timeout");
			RegexRunner.NativeFieldInfoPtr__ignoreTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "_ignoreTimeout");
			RegexRunner.NativeFieldInfoPtr__timeoutOccursAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "_timeoutOccursAt");
			RegexRunner.NativeFieldInfoPtr_TimeoutCheckFrequency = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "TimeoutCheckFrequency");
			RegexRunner.NativeFieldInfoPtr__timeoutChecksToSkip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, "_timeoutChecksToSkip");
			RegexRunner.NativeMethodInfoPtr__ctor_FamOrAssem_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664863);
			RegexRunner.NativeMethodInfoPtr_Scan_FamOrAssem_Match_Regex_String_Int32_Int32_Int32_Int32_Boolean_TimeSpan_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664864);
			RegexRunner.NativeMethodInfoPtr_StartTimeoutWatch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664865);
			RegexRunner.NativeMethodInfoPtr_CheckTimeout_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664866);
			RegexRunner.NativeMethodInfoPtr_DoCheckTimeout_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664867);
			RegexRunner.NativeMethodInfoPtr_Go_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664868);
			RegexRunner.NativeMethodInfoPtr_FindFirstChar_Protected_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664869);
			RegexRunner.NativeMethodInfoPtr_InitTrackCount_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664870);
			RegexRunner.NativeMethodInfoPtr_InitMatch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664871);
			RegexRunner.NativeMethodInfoPtr_TidyMatch_Private_Match_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664872);
			RegexRunner.NativeMethodInfoPtr_EnsureStorage_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664873);
			RegexRunner.NativeMethodInfoPtr_IsBoundary_Protected_Boolean_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664874);
			RegexRunner.NativeMethodInfoPtr_IsECMABoundary_Protected_Boolean_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664875);
			RegexRunner.NativeMethodInfoPtr_DoubleTrack_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664876);
			RegexRunner.NativeMethodInfoPtr_DoubleStack_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664877);
			RegexRunner.NativeMethodInfoPtr_DoubleCrawl_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664878);
			RegexRunner.NativeMethodInfoPtr_Crawl_Protected_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664879);
			RegexRunner.NativeMethodInfoPtr_Popcrawl_Protected_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664880);
			RegexRunner.NativeMethodInfoPtr_Crawlpos_Protected_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664881);
			RegexRunner.NativeMethodInfoPtr_Capture_Protected_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664882);
			RegexRunner.NativeMethodInfoPtr_TransferCapture_Protected_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664883);
			RegexRunner.NativeMethodInfoPtr_Uncapture_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664884);
			RegexRunner.NativeMethodInfoPtr_IsMatched_Protected_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664885);
			RegexRunner.NativeMethodInfoPtr_MatchIndex_Protected_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664886);
			RegexRunner.NativeMethodInfoPtr_MatchLength_Protected_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr, 100664887);
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00043808 File Offset: 0x00041A08
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexRunner()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexRunner>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr__ctor_FamOrAssem_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x00043844 File Offset: 0x00041A44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 442271, RefRangeEnd = 442272, XrefRangeStart = 442236, XrefRangeEnd = 442271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Match Scan(Regex regex, string text, int textbeg, int textend, int textstart, int prevlen, bool quick, TimeSpan timeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(regex);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textbeg;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textend;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref textstart;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prevlen;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quick;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_Scan_FamOrAssem_Match_Regex_String_Int32_Int32_Int32_Int32_Boolean_TimeSpan_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Match>(intPtr3) : null;
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x000438FC File Offset: 0x00041AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442272, XrefRangeEnd = 442273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartTimeoutWatch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_StartTimeoutWatch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x00043930 File Offset: 0x00041B30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 442274, RefRangeEnd = 442275, XrefRangeStart = 442273, XrefRangeEnd = 442274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckTimeout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_CheckTimeout_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x00043964 File Offset: 0x00041B64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442275, XrefRangeEnd = 442276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoCheckTimeout()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_DoCheckTimeout_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x00043998 File Offset: 0x00041B98
		[CallerCount(0)]
		public unsafe virtual void Go()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegexRunner.NativeMethodInfoPtr_Go_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x000439D4 File Offset: 0x00041BD4
		[CallerCount(0)]
		public unsafe virtual bool FindFirstChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegexRunner.NativeMethodInfoPtr_FindFirstChar_Protected_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x00043A1C File Offset: 0x00041C1C
		[CallerCount(0)]
		public unsafe virtual void InitTrackCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RegexRunner.NativeMethodInfoPtr_InitTrackCount_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x00043A58 File Offset: 0x00041C58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 442297, RefRangeEnd = 442298, XrefRangeStart = 442276, XrefRangeEnd = 442297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitMatch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_InitMatch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x00043A8C File Offset: 0x00041C8C
		[CallerCount(0)]
		public unsafe Match TidyMatch(bool quick)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref quick;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_TidyMatch_Private_Match_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Match>(intPtr3) : null;
			}
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x00043AD8 File Offset: 0x00041CD8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 442308, RefRangeEnd = 442311, XrefRangeStart = 442298, XrefRangeEnd = 442308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureStorage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_EnsureStorage_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x00043B0C File Offset: 0x00041D0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 442321, RefRangeEnd = 442323, XrefRangeStart = 442311, XrefRangeEnd = 442321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsBoundary(int index, int startpos, int endpos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startpos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endpos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_IsBoundary_Protected_Boolean_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00043B74 File Offset: 0x00041D74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 442333, RefRangeEnd = 442335, XrefRangeStart = 442323, XrefRangeEnd = 442333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsECMABoundary(int index, int startpos, int endpos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startpos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref endpos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_IsECMABoundary_Protected_Boolean_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x00043BDC File Offset: 0x00041DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442335, XrefRangeEnd = 442341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoubleTrack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_DoubleTrack_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x00043C10 File Offset: 0x00041E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442341, XrefRangeEnd = 442347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoubleStack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_DoubleStack_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x00043C44 File Offset: 0x00041E44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 442347, XrefRangeEnd = 442353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DoubleCrawl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_DoubleCrawl_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x00043C78 File Offset: 0x00041E78
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 442358, RefRangeEnd = 442361, XrefRangeStart = 442353, XrefRangeEnd = 442358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Crawl(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_Crawl_Protected_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A49 RID: 2633 RVA: 0x00043CB8 File Offset: 0x00041EB8
		[CallerCount(0)]
		public unsafe int Popcrawl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_Popcrawl_Protected_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00043CF4 File Offset: 0x00041EF4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 442361, RefRangeEnd = 442364, XrefRangeStart = 442361, XrefRangeEnd = 442361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Crawlpos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_Crawlpos_Protected_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00043D30 File Offset: 0x00041F30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 442366, RefRangeEnd = 442367, XrefRangeStart = 442364, XrefRangeEnd = 442366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Capture(int capnum, int start, int end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capnum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_Capture_Protected_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x00043D8C File Offset: 0x00041F8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 442370, RefRangeEnd = 442371, XrefRangeStart = 442367, XrefRangeEnd = 442370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TransferCapture(int capnum, int uncapnum, int start, int end)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref capnum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref uncapnum;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref end;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_TransferCapture_Protected_Void_Int32_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00043DF4 File Offset: 0x00041FF4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 442373, RefRangeEnd = 442377, XrefRangeStart = 442371, XrefRangeEnd = 442373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Uncapture()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_Uncapture_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00043E28 File Offset: 0x00042028
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 442378, RefRangeEnd = 442381, XrefRangeStart = 442377, XrefRangeEnd = 442378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsMatched(int cap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cap;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_IsMatched_Protected_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00043E74 File Offset: 0x00042074
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 442382, RefRangeEnd = 442383, XrefRangeStart = 442381, XrefRangeEnd = 442382, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int MatchIndex(int cap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cap;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_MatchIndex_Protected_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x00043EC0 File Offset: 0x000420C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 442384, RefRangeEnd = 442385, XrefRangeStart = 442383, XrefRangeEnd = 442384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int MatchLength(int cap)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cap;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexRunner.NativeMethodInfoPtr_MatchLength_Protected_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x0000576F File Offset: 0x0000396F
		public RegexRunner(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000A52 RID: 2642 RVA: 0x00043F0C File Offset: 0x0004210C
		// (set) Token: 0x06000A53 RID: 2643 RVA: 0x00005778 File Offset: 0x00003978
		public unsafe int runtextbeg
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtextbeg);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtextbeg)) = value;
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000A54 RID: 2644 RVA: 0x00043F34 File Offset: 0x00042134
		// (set) Token: 0x06000A55 RID: 2645 RVA: 0x00005793 File Offset: 0x00003993
		public unsafe int runtextend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtextend);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtextend)) = value;
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000A56 RID: 2646 RVA: 0x00043F5C File Offset: 0x0004215C
		// (set) Token: 0x06000A57 RID: 2647 RVA: 0x000057AE File Offset: 0x000039AE
		public unsafe int runtextstart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtextstart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtextstart)) = value;
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000A58 RID: 2648 RVA: 0x00043F84 File Offset: 0x00042184
		// (set) Token: 0x06000A59 RID: 2649 RVA: 0x000057C9 File Offset: 0x000039C9
		public unsafe string runtext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtext);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtext), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000A5A RID: 2650 RVA: 0x00043FAC File Offset: 0x000421AC
		// (set) Token: 0x06000A5B RID: 2651 RVA: 0x000057E8 File Offset: 0x000039E8
		public unsafe int runtextpos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtextpos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtextpos)) = value;
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000A5C RID: 2652 RVA: 0x00043FD4 File Offset: 0x000421D4
		// (set) Token: 0x06000A5D RID: 2653 RVA: 0x00005803 File Offset: 0x00003A03
		public unsafe Il2CppStructArray<int> runtrack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtrack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtrack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000A5E RID: 2654 RVA: 0x00044004 File Offset: 0x00042204
		// (set) Token: 0x06000A5F RID: 2655 RVA: 0x00005822 File Offset: 0x00003A22
		public unsafe int runtrackpos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtrackpos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtrackpos)) = value;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000A60 RID: 2656 RVA: 0x0004402C File Offset: 0x0004222C
		// (set) Token: 0x06000A61 RID: 2657 RVA: 0x0000583D File Offset: 0x00003A3D
		public unsafe Il2CppStructArray<int> runstack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runstack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runstack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000A62 RID: 2658 RVA: 0x0004405C File Offset: 0x0004225C
		// (set) Token: 0x06000A63 RID: 2659 RVA: 0x0000585C File Offset: 0x00003A5C
		public unsafe int runstackpos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runstackpos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runstackpos)) = value;
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000A64 RID: 2660 RVA: 0x00044084 File Offset: 0x00042284
		// (set) Token: 0x06000A65 RID: 2661 RVA: 0x00005877 File Offset: 0x00003A77
		public unsafe Il2CppStructArray<int> runcrawl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runcrawl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runcrawl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x000440B4 File Offset: 0x000422B4
		// (set) Token: 0x06000A67 RID: 2663 RVA: 0x00005896 File Offset: 0x00003A96
		public unsafe int runcrawlpos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runcrawlpos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runcrawlpos)) = value;
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000A68 RID: 2664 RVA: 0x000440DC File Offset: 0x000422DC
		// (set) Token: 0x06000A69 RID: 2665 RVA: 0x000058B1 File Offset: 0x00003AB1
		public unsafe int runtrackcount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtrackcount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runtrackcount)) = value;
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000A6A RID: 2666 RVA: 0x00044104 File Offset: 0x00042304
		// (set) Token: 0x06000A6B RID: 2667 RVA: 0x000058CC File Offset: 0x00003ACC
		public unsafe Match runmatch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runmatch);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Match>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runmatch), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000A6C RID: 2668 RVA: 0x00044134 File Offset: 0x00042334
		// (set) Token: 0x06000A6D RID: 2669 RVA: 0x000058EB File Offset: 0x00003AEB
		public unsafe Regex runregex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runregex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Regex>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr_runregex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000A6E RID: 2670 RVA: 0x00044164 File Offset: 0x00042364
		// (set) Token: 0x06000A6F RID: 2671 RVA: 0x0000590A File Offset: 0x00003B0A
		public unsafe int _timeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr__timeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr__timeout)) = value;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000A70 RID: 2672 RVA: 0x0004418C File Offset: 0x0004238C
		// (set) Token: 0x06000A71 RID: 2673 RVA: 0x00005925 File Offset: 0x00003B25
		public unsafe bool _ignoreTimeout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr__ignoreTimeout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr__ignoreTimeout)) = value;
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000A72 RID: 2674 RVA: 0x000441B4 File Offset: 0x000423B4
		// (set) Token: 0x06000A73 RID: 2675 RVA: 0x00005940 File Offset: 0x00003B40
		public unsafe int _timeoutOccursAt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr__timeoutOccursAt);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr__timeoutOccursAt)) = value;
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000A74 RID: 2676 RVA: 0x000441DC File Offset: 0x000423DC
		// (set) Token: 0x06000A75 RID: 2677 RVA: 0x0000595B File Offset: 0x00003B5B
		public unsafe static int TimeoutCheckFrequency
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(RegexRunner.NativeFieldInfoPtr_TimeoutCheckFrequency, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RegexRunner.NativeFieldInfoPtr_TimeoutCheckFrequency, (void*)(&value));
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000A76 RID: 2678 RVA: 0x000441F8 File Offset: 0x000423F8
		// (set) Token: 0x06000A77 RID: 2679 RVA: 0x00005969 File Offset: 0x00003B69
		public unsafe int _timeoutChecksToSkip
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr__timeoutChecksToSkip);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexRunner.NativeFieldInfoPtr__timeoutChecksToSkip)) = value;
			}
		}

		// Token: 0x04000840 RID: 2112
		private static readonly IntPtr NativeFieldInfoPtr_runtextbeg;

		// Token: 0x04000841 RID: 2113
		private static readonly IntPtr NativeFieldInfoPtr_runtextend;

		// Token: 0x04000842 RID: 2114
		private static readonly IntPtr NativeFieldInfoPtr_runtextstart;

		// Token: 0x04000843 RID: 2115
		private static readonly IntPtr NativeFieldInfoPtr_runtext;

		// Token: 0x04000844 RID: 2116
		private static readonly IntPtr NativeFieldInfoPtr_runtextpos;

		// Token: 0x04000845 RID: 2117
		private static readonly IntPtr NativeFieldInfoPtr_runtrack;

		// Token: 0x04000846 RID: 2118
		private static readonly IntPtr NativeFieldInfoPtr_runtrackpos;

		// Token: 0x04000847 RID: 2119
		private static readonly IntPtr NativeFieldInfoPtr_runstack;

		// Token: 0x04000848 RID: 2120
		private static readonly IntPtr NativeFieldInfoPtr_runstackpos;

		// Token: 0x04000849 RID: 2121
		private static readonly IntPtr NativeFieldInfoPtr_runcrawl;

		// Token: 0x0400084A RID: 2122
		private static readonly IntPtr NativeFieldInfoPtr_runcrawlpos;

		// Token: 0x0400084B RID: 2123
		private static readonly IntPtr NativeFieldInfoPtr_runtrackcount;

		// Token: 0x0400084C RID: 2124
		private static readonly IntPtr NativeFieldInfoPtr_runmatch;

		// Token: 0x0400084D RID: 2125
		private static readonly IntPtr NativeFieldInfoPtr_runregex;

		// Token: 0x0400084E RID: 2126
		private static readonly IntPtr NativeFieldInfoPtr__timeout;

		// Token: 0x0400084F RID: 2127
		private static readonly IntPtr NativeFieldInfoPtr__ignoreTimeout;

		// Token: 0x04000850 RID: 2128
		private static readonly IntPtr NativeFieldInfoPtr__timeoutOccursAt;

		// Token: 0x04000851 RID: 2129
		private static readonly IntPtr NativeFieldInfoPtr_TimeoutCheckFrequency;

		// Token: 0x04000852 RID: 2130
		private static readonly IntPtr NativeFieldInfoPtr__timeoutChecksToSkip;

		// Token: 0x04000853 RID: 2131
		private static readonly IntPtr NativeMethodInfoPtr__ctor_FamOrAssem_Void_0;

		// Token: 0x04000854 RID: 2132
		private static readonly IntPtr NativeMethodInfoPtr_Scan_FamOrAssem_Match_Regex_String_Int32_Int32_Int32_Int32_Boolean_TimeSpan_0;

		// Token: 0x04000855 RID: 2133
		private static readonly IntPtr NativeMethodInfoPtr_StartTimeoutWatch_Private_Void_0;

		// Token: 0x04000856 RID: 2134
		private static readonly IntPtr NativeMethodInfoPtr_CheckTimeout_Protected_Void_0;

		// Token: 0x04000857 RID: 2135
		private static readonly IntPtr NativeMethodInfoPtr_DoCheckTimeout_Private_Void_0;

		// Token: 0x04000858 RID: 2136
		private static readonly IntPtr NativeMethodInfoPtr_Go_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x04000859 RID: 2137
		private static readonly IntPtr NativeMethodInfoPtr_FindFirstChar_Protected_Abstract_Virtual_New_Boolean_0;

		// Token: 0x0400085A RID: 2138
		private static readonly IntPtr NativeMethodInfoPtr_InitTrackCount_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x0400085B RID: 2139
		private static readonly IntPtr NativeMethodInfoPtr_InitMatch_Private_Void_0;

		// Token: 0x0400085C RID: 2140
		private static readonly IntPtr NativeMethodInfoPtr_TidyMatch_Private_Match_Boolean_0;

		// Token: 0x0400085D RID: 2141
		private static readonly IntPtr NativeMethodInfoPtr_EnsureStorage_Protected_Void_0;

		// Token: 0x0400085E RID: 2142
		private static readonly IntPtr NativeMethodInfoPtr_IsBoundary_Protected_Boolean_Int32_Int32_Int32_0;

		// Token: 0x0400085F RID: 2143
		private static readonly IntPtr NativeMethodInfoPtr_IsECMABoundary_Protected_Boolean_Int32_Int32_Int32_0;

		// Token: 0x04000860 RID: 2144
		private static readonly IntPtr NativeMethodInfoPtr_DoubleTrack_Protected_Void_0;

		// Token: 0x04000861 RID: 2145
		private static readonly IntPtr NativeMethodInfoPtr_DoubleStack_Protected_Void_0;

		// Token: 0x04000862 RID: 2146
		private static readonly IntPtr NativeMethodInfoPtr_DoubleCrawl_Protected_Void_0;

		// Token: 0x04000863 RID: 2147
		private static readonly IntPtr NativeMethodInfoPtr_Crawl_Protected_Void_Int32_0;

		// Token: 0x04000864 RID: 2148
		private static readonly IntPtr NativeMethodInfoPtr_Popcrawl_Protected_Int32_0;

		// Token: 0x04000865 RID: 2149
		private static readonly IntPtr NativeMethodInfoPtr_Crawlpos_Protected_Int32_0;

		// Token: 0x04000866 RID: 2150
		private static readonly IntPtr NativeMethodInfoPtr_Capture_Protected_Void_Int32_Int32_Int32_0;

		// Token: 0x04000867 RID: 2151
		private static readonly IntPtr NativeMethodInfoPtr_TransferCapture_Protected_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000868 RID: 2152
		private static readonly IntPtr NativeMethodInfoPtr_Uncapture_Protected_Void_0;

		// Token: 0x04000869 RID: 2153
		private static readonly IntPtr NativeMethodInfoPtr_IsMatched_Protected_Boolean_Int32_0;

		// Token: 0x0400086A RID: 2154
		private static readonly IntPtr NativeMethodInfoPtr_MatchIndex_Protected_Int32_Int32_0;

		// Token: 0x0400086B RID: 2155
		private static readonly IntPtr NativeMethodInfoPtr_MatchLength_Protected_Int32_Int32_0;
	}
}
