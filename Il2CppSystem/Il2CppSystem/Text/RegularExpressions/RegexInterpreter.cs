using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000082 RID: 130
	public sealed class RegexInterpreter : RegexRunner
	{
		// Token: 0x06000933 RID: 2355 RVA: 0x0003F2FC File Offset: 0x0003D4FC
		// Note: this type is marked as 'beforefieldinit'.
		static RegexInterpreter()
		{
			Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "RegexInterpreter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr);
			RegexInterpreter.NativeFieldInfoPtr__code = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, "_code");
			RegexInterpreter.NativeFieldInfoPtr__culture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, "_culture");
			RegexInterpreter.NativeFieldInfoPtr__operator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, "_operator");
			RegexInterpreter.NativeFieldInfoPtr__codepos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, "_codepos");
			RegexInterpreter.NativeFieldInfoPtr__rightToLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, "_rightToLeft");
			RegexInterpreter.NativeFieldInfoPtr__caseInsensitive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, "_caseInsensitive");
			RegexInterpreter.NativeMethodInfoPtr__ctor_Public_Void_RegexCode_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664710);
			RegexInterpreter.NativeMethodInfoPtr_InitTrackCount_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664711);
			RegexInterpreter.NativeMethodInfoPtr_Advance_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664712);
			RegexInterpreter.NativeMethodInfoPtr_Goto_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664713);
			RegexInterpreter.NativeMethodInfoPtr_Textto_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664714);
			RegexInterpreter.NativeMethodInfoPtr_Trackto_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664715);
			RegexInterpreter.NativeMethodInfoPtr_Textstart_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664716);
			RegexInterpreter.NativeMethodInfoPtr_Textpos_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664717);
			RegexInterpreter.NativeMethodInfoPtr_Trackpos_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664718);
			RegexInterpreter.NativeMethodInfoPtr_TrackPush_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664719);
			RegexInterpreter.NativeMethodInfoPtr_TrackPush_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664720);
			RegexInterpreter.NativeMethodInfoPtr_TrackPush_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664721);
			RegexInterpreter.NativeMethodInfoPtr_TrackPush_Private_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664722);
			RegexInterpreter.NativeMethodInfoPtr_TrackPush2_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664723);
			RegexInterpreter.NativeMethodInfoPtr_TrackPush2_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664724);
			RegexInterpreter.NativeMethodInfoPtr_Backtrack_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664725);
			RegexInterpreter.NativeMethodInfoPtr_SetOperator_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664726);
			RegexInterpreter.NativeMethodInfoPtr_TrackPop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664727);
			RegexInterpreter.NativeMethodInfoPtr_TrackPop_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664728);
			RegexInterpreter.NativeMethodInfoPtr_TrackPeek_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664729);
			RegexInterpreter.NativeMethodInfoPtr_TrackPeek_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664730);
			RegexInterpreter.NativeMethodInfoPtr_StackPush_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664731);
			RegexInterpreter.NativeMethodInfoPtr_StackPush_Private_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664732);
			RegexInterpreter.NativeMethodInfoPtr_StackPop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664733);
			RegexInterpreter.NativeMethodInfoPtr_StackPop_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664734);
			RegexInterpreter.NativeMethodInfoPtr_StackPeek_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664735);
			RegexInterpreter.NativeMethodInfoPtr_StackPeek_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664736);
			RegexInterpreter.NativeMethodInfoPtr_Operator_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664737);
			RegexInterpreter.NativeMethodInfoPtr_Operand_Private_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664738);
			RegexInterpreter.NativeMethodInfoPtr_Leftchars_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664739);
			RegexInterpreter.NativeMethodInfoPtr_Rightchars_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664740);
			RegexInterpreter.NativeMethodInfoPtr_Bump_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664741);
			RegexInterpreter.NativeMethodInfoPtr_Forwardchars_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664742);
			RegexInterpreter.NativeMethodInfoPtr_Forwardcharnext_Private_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664743);
			RegexInterpreter.NativeMethodInfoPtr_Stringmatch_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664744);
			RegexInterpreter.NativeMethodInfoPtr_Refmatch_Private_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664745);
			RegexInterpreter.NativeMethodInfoPtr_Backwardnext_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664746);
			RegexInterpreter.NativeMethodInfoPtr_CharAt_Private_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664747);
			RegexInterpreter.NativeMethodInfoPtr_FindFirstChar_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664748);
			RegexInterpreter.NativeMethodInfoPtr_Go_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr, 100664749);
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x0003F6C4 File Offset: 0x0003D8C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440690, XrefRangeEnd = 440693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexInterpreter(RegexCode code, CultureInfo culture)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RegexInterpreter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(code);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr__ctor_Public_Void_RegexCode_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x0003F724 File Offset: 0x0003D924
		[CallerCount(0)]
		public unsafe override void InitTrackCount()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_InitTrackCount_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x0003F758 File Offset: 0x0003D958
		[CallerCount(0)]
		public unsafe void Advance(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Advance_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x0003F798 File Offset: 0x0003D998
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 440694, RefRangeEnd = 440697, XrefRangeStart = 440693, XrefRangeEnd = 440694, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Goto(int newpos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newpos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Goto_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x0003F7D8 File Offset: 0x0003D9D8
		[CallerCount(0)]
		public unsafe void Textto(int newpos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newpos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Textto_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x0003F818 File Offset: 0x0003DA18
		[CallerCount(0)]
		public unsafe void Trackto(int newpos)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newpos;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Trackto_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x0003F858 File Offset: 0x0003DA58
		[CallerCount(0)]
		public unsafe int Textstart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Textstart_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x0003F894 File Offset: 0x0003DA94
		[CallerCount(0)]
		public unsafe int Textpos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Textpos_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x0003F8D0 File Offset: 0x0003DAD0
		[CallerCount(0)]
		public unsafe int Trackpos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Trackpos_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x0003F90C File Offset: 0x0003DB0C
		[CallerCount(0)]
		public unsafe void TrackPush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_TrackPush_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x0003F940 File Offset: 0x0003DB40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 440697, RefRangeEnd = 440698, XrefRangeStart = 440697, XrefRangeEnd = 440697, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrackPush(int I1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref I1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_TrackPush_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x0003F980 File Offset: 0x0003DB80
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 440698, RefRangeEnd = 440707, XrefRangeStart = 440698, XrefRangeEnd = 440698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrackPush(int I1, int I2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref I1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref I2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_TrackPush_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x0003F9CC File Offset: 0x0003DBCC
		[CallerCount(0)]
		public unsafe void TrackPush(int I1, int I2, int I3)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref I1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref I2;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref I3;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_TrackPush_Private_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x0003FA28 File Offset: 0x0003DC28
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 440707, RefRangeEnd = 440713, XrefRangeStart = 440707, XrefRangeEnd = 440707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrackPush2(int I1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref I1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_TrackPush2_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x0003FA68 File Offset: 0x0003DC68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 440713, RefRangeEnd = 440714, XrefRangeStart = 440713, XrefRangeEnd = 440713, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TrackPush2(int I1, int I2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref I1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref I2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_TrackPush2_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x0003FAB4 File Offset: 0x0003DCB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440714, XrefRangeEnd = 440716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Backtrack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Backtrack_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x0003FAE8 File Offset: 0x0003DCE8
		[CallerCount(0)]
		public unsafe void SetOperator(int op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref op;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_SetOperator_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x0003FB28 File Offset: 0x0003DD28
		[CallerCount(0)]
		public unsafe void TrackPop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_TrackPop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x0003FB5C File Offset: 0x0003DD5C
		[CallerCount(0)]
		public unsafe void TrackPop(int framesize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref framesize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_TrackPop_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x0003FB9C File Offset: 0x0003DD9C
		[CallerCount(0)]
		public unsafe int TrackPeek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_TrackPeek_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x0003FBD8 File Offset: 0x0003DDD8
		[CallerCount(0)]
		public unsafe int TrackPeek(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_TrackPeek_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x0003FC24 File Offset: 0x0003DE24
		[CallerCount(0)]
		public unsafe void StackPush(int I1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref I1;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_StackPush_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x0003FC64 File Offset: 0x0003DE64
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 440716, RefRangeEnd = 440720, XrefRangeStart = 440716, XrefRangeEnd = 440716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StackPush(int I1, int I2)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref I1;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref I2;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_StackPush_Private_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x0003FCB0 File Offset: 0x0003DEB0
		[CallerCount(0)]
		public unsafe void StackPop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_StackPop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x0003FCE4 File Offset: 0x0003DEE4
		[CallerCount(0)]
		public unsafe void StackPop(int framesize)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref framesize;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_StackPop_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x0003FD24 File Offset: 0x0003DF24
		[CallerCount(0)]
		public unsafe int StackPeek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_StackPeek_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x0003FD60 File Offset: 0x0003DF60
		[CallerCount(0)]
		public unsafe int StackPeek(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_StackPeek_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x0003FDAC File Offset: 0x0003DFAC
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 311826, RefRangeEnd = 311839, XrefRangeStart = 311826, XrefRangeEnd = 311839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Operator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Operator_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x0003FDE8 File Offset: 0x0003DFE8
		[CallerCount(0)]
		public unsafe int Operand(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Operand_Private_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x0003FE34 File Offset: 0x0003E034
		[CallerCount(0)]
		public unsafe int Leftchars()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Leftchars_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x0003FE70 File Offset: 0x0003E070
		[CallerCount(0)]
		public unsafe int Rightchars()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Rightchars_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x0003FEAC File Offset: 0x0003E0AC
		[CallerCount(0)]
		public unsafe int Bump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Bump_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x0003FEE8 File Offset: 0x0003E0E8
		[CallerCount(0)]
		public unsafe int Forwardchars()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Forwardchars_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x0003FF24 File Offset: 0x0003E124
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 440722, RefRangeEnd = 440734, XrefRangeStart = 440720, XrefRangeEnd = 440722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char Forwardcharnext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Forwardcharnext_Private_Char_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x0003FF60 File Offset: 0x0003E160
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 440737, RefRangeEnd = 440738, XrefRangeStart = 440734, XrefRangeEnd = 440737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Stringmatch(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Stringmatch_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x0003FFB0 File Offset: 0x0003E1B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 440741, RefRangeEnd = 440742, XrefRangeStart = 440738, XrefRangeEnd = 440741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Refmatch(int index, int len)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref len;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Refmatch_Private_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00040008 File Offset: 0x0003E208
		[CallerCount(0)]
		public unsafe void Backwardnext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Backwardnext_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x0004003C File Offset: 0x0003E23C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440742, XrefRangeEnd = 440744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe char CharAt(int j)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref j;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_CharAt_Private_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00040088 File Offset: 0x0003E288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440744, XrefRangeEnd = 440769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool FindFirstChar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_FindFirstChar_Protected_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x000400C4 File Offset: 0x0003E2C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 440769, XrefRangeEnd = 440923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Go()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RegexInterpreter.NativeMethodInfoPtr_Go_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x00005209 File Offset: 0x00003409
		public RegexInterpreter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x0600095D RID: 2397 RVA: 0x000400F8 File Offset: 0x0003E2F8
		// (set) Token: 0x0600095E RID: 2398 RVA: 0x00005212 File Offset: 0x00003412
		public unsafe RegexCode _code
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr__code);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexCode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr__code), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x0600095F RID: 2399 RVA: 0x00040128 File Offset: 0x0003E328
		// (set) Token: 0x06000960 RID: 2400 RVA: 0x00005231 File Offset: 0x00003431
		public unsafe CultureInfo _culture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr__culture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CultureInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr__culture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000961 RID: 2401 RVA: 0x00040158 File Offset: 0x0003E358
		// (set) Token: 0x06000962 RID: 2402 RVA: 0x00005250 File Offset: 0x00003450
		public unsafe int _operator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr__operator);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr__operator)) = value;
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000963 RID: 2403 RVA: 0x00040180 File Offset: 0x0003E380
		// (set) Token: 0x06000964 RID: 2404 RVA: 0x0000526B File Offset: 0x0000346B
		public unsafe int _codepos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr__codepos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr__codepos)) = value;
			}
		}

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x000401A8 File Offset: 0x0003E3A8
		// (set) Token: 0x06000966 RID: 2406 RVA: 0x00005286 File Offset: 0x00003486
		public unsafe bool _rightToLeft
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr__rightToLeft);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr__rightToLeft)) = value;
			}
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000967 RID: 2407 RVA: 0x000401D0 File Offset: 0x0003E3D0
		// (set) Token: 0x06000968 RID: 2408 RVA: 0x000052A1 File Offset: 0x000034A1
		public unsafe bool _caseInsensitive
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr__caseInsensitive);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RegexInterpreter.NativeFieldInfoPtr__caseInsensitive)) = value;
			}
		}

		// Token: 0x0400076E RID: 1902
		private static readonly IntPtr NativeFieldInfoPtr__code;

		// Token: 0x0400076F RID: 1903
		private static readonly IntPtr NativeFieldInfoPtr__culture;

		// Token: 0x04000770 RID: 1904
		private static readonly IntPtr NativeFieldInfoPtr__operator;

		// Token: 0x04000771 RID: 1905
		private static readonly IntPtr NativeFieldInfoPtr__codepos;

		// Token: 0x04000772 RID: 1906
		private static readonly IntPtr NativeFieldInfoPtr__rightToLeft;

		// Token: 0x04000773 RID: 1907
		private static readonly IntPtr NativeFieldInfoPtr__caseInsensitive;

		// Token: 0x04000774 RID: 1908
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RegexCode_CultureInfo_0;

		// Token: 0x04000775 RID: 1909
		private static readonly IntPtr NativeMethodInfoPtr_InitTrackCount_Protected_Virtual_Void_0;

		// Token: 0x04000776 RID: 1910
		private static readonly IntPtr NativeMethodInfoPtr_Advance_Private_Void_Int32_0;

		// Token: 0x04000777 RID: 1911
		private static readonly IntPtr NativeMethodInfoPtr_Goto_Private_Void_Int32_0;

		// Token: 0x04000778 RID: 1912
		private static readonly IntPtr NativeMethodInfoPtr_Textto_Private_Void_Int32_0;

		// Token: 0x04000779 RID: 1913
		private static readonly IntPtr NativeMethodInfoPtr_Trackto_Private_Void_Int32_0;

		// Token: 0x0400077A RID: 1914
		private static readonly IntPtr NativeMethodInfoPtr_Textstart_Private_Int32_0;

		// Token: 0x0400077B RID: 1915
		private static readonly IntPtr NativeMethodInfoPtr_Textpos_Private_Int32_0;

		// Token: 0x0400077C RID: 1916
		private static readonly IntPtr NativeMethodInfoPtr_Trackpos_Private_Int32_0;

		// Token: 0x0400077D RID: 1917
		private static readonly IntPtr NativeMethodInfoPtr_TrackPush_Private_Void_0;

		// Token: 0x0400077E RID: 1918
		private static readonly IntPtr NativeMethodInfoPtr_TrackPush_Private_Void_Int32_0;

		// Token: 0x0400077F RID: 1919
		private static readonly IntPtr NativeMethodInfoPtr_TrackPush_Private_Void_Int32_Int32_0;

		// Token: 0x04000780 RID: 1920
		private static readonly IntPtr NativeMethodInfoPtr_TrackPush_Private_Void_Int32_Int32_Int32_0;

		// Token: 0x04000781 RID: 1921
		private static readonly IntPtr NativeMethodInfoPtr_TrackPush2_Private_Void_Int32_0;

		// Token: 0x04000782 RID: 1922
		private static readonly IntPtr NativeMethodInfoPtr_TrackPush2_Private_Void_Int32_Int32_0;

		// Token: 0x04000783 RID: 1923
		private static readonly IntPtr NativeMethodInfoPtr_Backtrack_Private_Void_0;

		// Token: 0x04000784 RID: 1924
		private static readonly IntPtr NativeMethodInfoPtr_SetOperator_Private_Void_Int32_0;

		// Token: 0x04000785 RID: 1925
		private static readonly IntPtr NativeMethodInfoPtr_TrackPop_Private_Void_0;

		// Token: 0x04000786 RID: 1926
		private static readonly IntPtr NativeMethodInfoPtr_TrackPop_Private_Void_Int32_0;

		// Token: 0x04000787 RID: 1927
		private static readonly IntPtr NativeMethodInfoPtr_TrackPeek_Private_Int32_0;

		// Token: 0x04000788 RID: 1928
		private static readonly IntPtr NativeMethodInfoPtr_TrackPeek_Private_Int32_Int32_0;

		// Token: 0x04000789 RID: 1929
		private static readonly IntPtr NativeMethodInfoPtr_StackPush_Private_Void_Int32_0;

		// Token: 0x0400078A RID: 1930
		private static readonly IntPtr NativeMethodInfoPtr_StackPush_Private_Void_Int32_Int32_0;

		// Token: 0x0400078B RID: 1931
		private static readonly IntPtr NativeMethodInfoPtr_StackPop_Private_Void_0;

		// Token: 0x0400078C RID: 1932
		private static readonly IntPtr NativeMethodInfoPtr_StackPop_Private_Void_Int32_0;

		// Token: 0x0400078D RID: 1933
		private static readonly IntPtr NativeMethodInfoPtr_StackPeek_Private_Int32_0;

		// Token: 0x0400078E RID: 1934
		private static readonly IntPtr NativeMethodInfoPtr_StackPeek_Private_Int32_Int32_0;

		// Token: 0x0400078F RID: 1935
		private static readonly IntPtr NativeMethodInfoPtr_Operator_Private_Int32_0;

		// Token: 0x04000790 RID: 1936
		private static readonly IntPtr NativeMethodInfoPtr_Operand_Private_Int32_Int32_0;

		// Token: 0x04000791 RID: 1937
		private static readonly IntPtr NativeMethodInfoPtr_Leftchars_Private_Int32_0;

		// Token: 0x04000792 RID: 1938
		private static readonly IntPtr NativeMethodInfoPtr_Rightchars_Private_Int32_0;

		// Token: 0x04000793 RID: 1939
		private static readonly IntPtr NativeMethodInfoPtr_Bump_Private_Int32_0;

		// Token: 0x04000794 RID: 1940
		private static readonly IntPtr NativeMethodInfoPtr_Forwardchars_Private_Int32_0;

		// Token: 0x04000795 RID: 1941
		private static readonly IntPtr NativeMethodInfoPtr_Forwardcharnext_Private_Char_0;

		// Token: 0x04000796 RID: 1942
		private static readonly IntPtr NativeMethodInfoPtr_Stringmatch_Private_Boolean_String_0;

		// Token: 0x04000797 RID: 1943
		private static readonly IntPtr NativeMethodInfoPtr_Refmatch_Private_Boolean_Int32_Int32_0;

		// Token: 0x04000798 RID: 1944
		private static readonly IntPtr NativeMethodInfoPtr_Backwardnext_Private_Void_0;

		// Token: 0x04000799 RID: 1945
		private static readonly IntPtr NativeMethodInfoPtr_CharAt_Private_Char_Int32_0;

		// Token: 0x0400079A RID: 1946
		private static readonly IntPtr NativeMethodInfoPtr_FindFirstChar_Protected_Virtual_Boolean_0;

		// Token: 0x0400079B RID: 1947
		private static readonly IntPtr NativeMethodInfoPtr_Go_Protected_Virtual_Void_0;
	}
}
