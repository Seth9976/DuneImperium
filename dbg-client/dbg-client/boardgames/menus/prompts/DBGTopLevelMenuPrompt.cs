using System;
using System.Runtime.InteropServices;
using dwd.core.ui.prompt.prompts;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace boardgames.menus.prompts
{
	// Token: 0x020001EC RID: 492
	public class DBGTopLevelMenuPrompt : BasePrompt
	{
		// Token: 0x060016FB RID: 5883 RVA: 0x0006804C File Offset: 0x0006624C
		// Note: this type is marked as 'beforefieldinit'.
		static DBGTopLevelMenuPrompt()
		{
			Il2CppClassPointerStore<DBGTopLevelMenuPrompt>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.menus.prompts", "DBGTopLevelMenuPrompt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGTopLevelMenuPrompt>.NativeClassPtr);
			DBGTopLevelMenuPrompt.NativeFieldInfoPtr_backToPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTopLevelMenuPrompt>.NativeClassPtr, "backToPrompt");
			DBGTopLevelMenuPrompt.NativeMethodInfoPtr_YieldsTo_Public_Virtual_Final_New_Boolean_IPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTopLevelMenuPrompt>.NativeClassPtr, 100666659);
			DBGTopLevelMenuPrompt.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTopLevelMenuPrompt>.NativeClassPtr, 100666660);
			DBGTopLevelMenuPrompt.NativeMethodInfoPtr__ctor_Protected_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTopLevelMenuPrompt>.NativeClassPtr, 100666661);
			DBGTopLevelMenuPrompt.NativeMethodInfoPtr__ctor_Protected_Void_IReturnablePrompt_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTopLevelMenuPrompt>.NativeClassPtr, 100666662);
			DBGTopLevelMenuPrompt.NativeMethodInfoPtr_SetPromptForBack_Public_Void_IReturnablePrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTopLevelMenuPrompt>.NativeClassPtr, 100666663);
			DBGTopLevelMenuPrompt.NativeMethodInfoPtr_get_DismissOnYield_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTopLevelMenuPrompt>.NativeClassPtr, 100666664);
			DBGTopLevelMenuPrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTopLevelMenuPrompt>.NativeClassPtr, 100666665);
			DBGTopLevelMenuPrompt.NativeMethodInfoPtr_Return_Public_Virtual_Final_New_IReturnablePrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTopLevelMenuPrompt>.NativeClassPtr, 100666666);
			DBGTopLevelMenuPrompt.NativeMethodInfoPtr_prepareReturn_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTopLevelMenuPrompt>.NativeClassPtr, 100666667);
			DBGTopLevelMenuPrompt.NativeMethodInfoPtr_GoBackToPrompt_Public_Void_ModalScope_IPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTopLevelMenuPrompt>.NativeClassPtr, 100666668);
			DBGTopLevelMenuPrompt.NativeMethodInfoPtr_GoBackToPromptAndWait_Public_IEnumerator_ModalScope_IPrompt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTopLevelMenuPrompt>.NativeClassPtr, 100666669);
			DBGTopLevelMenuPrompt.NativeMethodInfoPtr_prepareGoBack_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTopLevelMenuPrompt>.NativeClassPtr, 100666670);
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x00068180 File Offset: 0x00066380
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525015, XrefRangeEnd = 525016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool YieldsTo(IPrompt otherPrompt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(otherPrompt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTopLevelMenuPrompt.NativeMethodInfoPtr_YieldsTo_Public_Virtual_Final_New_Boolean_IPrompt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x000681D0 File Offset: 0x000663D0
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 524574, RefRangeEnd = 524584, XrefRangeStart = 524574, XrefRangeEnd = 524584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGTopLevelMenuPrompt()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGTopLevelMenuPrompt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTopLevelMenuPrompt.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x0006820C File Offset: 0x0006640C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525016, XrefRangeEnd = 525018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGTopLevelMenuPrompt([Optional] Il2CppStringArray args)
		{
			if (args == null)
			{
				args = new Il2CppStringArray(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGTopLevelMenuPrompt>.NativeClassPtr));
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTopLevelMenuPrompt.NativeMethodInfoPtr__ctor_Protected_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x00068264 File Offset: 0x00066464
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525018, XrefRangeEnd = 525020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGTopLevelMenuPrompt(IReturnablePrompt backToPrompt, [Optional] Il2CppStringArray args)
		{
			if (args == null)
			{
				args = new Il2CppStringArray(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGTopLevelMenuPrompt>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(backToPrompt);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTopLevelMenuPrompt.NativeMethodInfoPtr__ctor_Protected_Void_IReturnablePrompt_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001700 RID: 5888 RVA: 0x000682D0 File Offset: 0x000664D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPromptForBack(IReturnablePrompt backToPrompt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(backToPrompt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTopLevelMenuPrompt.NativeMethodInfoPtr_SetPromptForBack_Public_Void_IReturnablePrompt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000630 RID: 1584
		// (get) Token: 0x06001701 RID: 5889 RVA: 0x00068314 File Offset: 0x00066514
		public unsafe virtual bool DismissOnYield
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTopLevelMenuPrompt.NativeMethodInfoPtr_get_DismissOnYield_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001702 RID: 5890 RVA: 0x00068350 File Offset: 0x00066550
		[CallerCount(88)]
		[CachedScanResults(RefRangeStart = 525020, RefRangeEnd = 525108, XrefRangeStart = 525020, XrefRangeEnd = 525020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dismiss()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGTopLevelMenuPrompt.NativeMethodInfoPtr_Dismiss_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001703 RID: 5891 RVA: 0x0006838C File Offset: 0x0006658C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525108, XrefRangeEnd = 525113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IReturnablePrompt Return()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTopLevelMenuPrompt.NativeMethodInfoPtr_Return_Public_Virtual_Final_New_IReturnablePrompt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IReturnablePrompt>(intPtr3) : null;
		}

		// Token: 0x06001704 RID: 5892 RVA: 0x000683CC File Offset: 0x000665CC
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void prepareReturn()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGTopLevelMenuPrompt.NativeMethodInfoPtr_prepareReturn_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001705 RID: 5893 RVA: 0x00068408 File Offset: 0x00066608
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525113, XrefRangeEnd = 525121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GoBackToPrompt(ModalScope scope, IPrompt defaultPrompt = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scope);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultPrompt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTopLevelMenuPrompt.NativeMethodInfoPtr_GoBackToPrompt_Public_Void_ModalScope_IPrompt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001706 RID: 5894 RVA: 0x0006845C File Offset: 0x0006665C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525121, XrefRangeEnd = 525128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator GoBackToPromptAndWait(ModalScope scope, IPrompt defaultPrompt = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(scope);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultPrompt);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTopLevelMenuPrompt.NativeMethodInfoPtr_GoBackToPromptAndWait_Public_IEnumerator_ModalScope_IPrompt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001707 RID: 5895 RVA: 0x000684C0 File Offset: 0x000666C0
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void prepareGoBack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DBGTopLevelMenuPrompt.NativeMethodInfoPtr_prepareGoBack_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001708 RID: 5896 RVA: 0x0000CE6E File Offset: 0x0000B06E
		public DBGTopLevelMenuPrompt(params string[] args)
			: this(new Il2CppStringArray(args))
		{
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x0000CE7C File Offset: 0x0000B07C
		public DBGTopLevelMenuPrompt(IReturnablePrompt backToPrompt, params string[] args)
			: this(backToPrompt, new Il2CppStringArray(args))
		{
		}

		// Token: 0x0600170A RID: 5898 RVA: 0x0000CE8B File Offset: 0x0000B08B
		public DBGTopLevelMenuPrompt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x0600170B RID: 5899 RVA: 0x000684FC File Offset: 0x000666FC
		// (set) Token: 0x0600170C RID: 5900 RVA: 0x0000CE94 File Offset: 0x0000B094
		public unsafe IReturnablePrompt backToPrompt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTopLevelMenuPrompt.NativeFieldInfoPtr_backToPrompt);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IReturnablePrompt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTopLevelMenuPrompt.NativeFieldInfoPtr_backToPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E4C RID: 3660
		private static readonly IntPtr NativeFieldInfoPtr_backToPrompt;

		// Token: 0x04000E4D RID: 3661
		private static readonly IntPtr NativeMethodInfoPtr_YieldsTo_Public_Virtual_Final_New_Boolean_IPrompt_0;

		// Token: 0x04000E4E RID: 3662
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000E4F RID: 3663
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Il2CppStringArray_0;

		// Token: 0x04000E50 RID: 3664
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_IReturnablePrompt_Il2CppStringArray_0;

		// Token: 0x04000E51 RID: 3665
		private static readonly IntPtr NativeMethodInfoPtr_SetPromptForBack_Public_Void_IReturnablePrompt_0;

		// Token: 0x04000E52 RID: 3666
		private static readonly IntPtr NativeMethodInfoPtr_get_DismissOnYield_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000E53 RID: 3667
		private static readonly IntPtr NativeMethodInfoPtr_Dismiss_Public_Virtual_New_Void_0;

		// Token: 0x04000E54 RID: 3668
		private static readonly IntPtr NativeMethodInfoPtr_Return_Public_Virtual_Final_New_IReturnablePrompt_0;

		// Token: 0x04000E55 RID: 3669
		private static readonly IntPtr NativeMethodInfoPtr_prepareReturn_Protected_Virtual_New_Void_0;

		// Token: 0x04000E56 RID: 3670
		private static readonly IntPtr NativeMethodInfoPtr_GoBackToPrompt_Public_Void_ModalScope_IPrompt_0;

		// Token: 0x04000E57 RID: 3671
		private static readonly IntPtr NativeMethodInfoPtr_GoBackToPromptAndWait_Public_IEnumerator_ModalScope_IPrompt_0;

		// Token: 0x04000E58 RID: 3672
		private static readonly IntPtr NativeMethodInfoPtr_prepareGoBack_Protected_Virtual_New_Void_0;

		// Token: 0x020003D4 RID: 980
		[ObfuscatedName("boardgames.menus.prompts.DBGTopLevelMenuPrompt+<GoBackToPromptAndWait>d__12")]
		public sealed class _GoBackToPromptAndWait_d__12 : Object
		{
			// Token: 0x06002D96 RID: 11670 RVA: 0x000B0A24 File Offset: 0x000AEC24
			// Note: this type is marked as 'beforefieldinit'.
			static _GoBackToPromptAndWait_d__12()
			{
				Il2CppClassPointerStore<DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DBGTopLevelMenuPrompt>.NativeClassPtr, "<GoBackToPromptAndWait>d__12");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12>.NativeClassPtr);
				DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12>.NativeClassPtr, "<>1__state");
				DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12>.NativeClassPtr, "<>2__current");
				DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12>.NativeClassPtr, "<>4__this");
				DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12.NativeFieldInfoPtr_scope = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12>.NativeClassPtr, "scope");
				DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12.NativeFieldInfoPtr_defaultPrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12>.NativeClassPtr, "defaultPrompt");
				DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12>.NativeClassPtr, 100666671);
				DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12>.NativeClassPtr, 100666672);
				DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12>.NativeClassPtr, 100666673);
				DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12>.NativeClassPtr, 100666674);
				DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12>.NativeClassPtr, 100666675);
				DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12>.NativeClassPtr, 100666676);
			}

			// Token: 0x06002D97 RID: 11671 RVA: 0x000B0B2C File Offset: 0x000AED2C
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _GoBackToPromptAndWait_d__12(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002D98 RID: 11672 RVA: 0x000B0B74 File Offset: 0x000AED74
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002D99 RID: 11673 RVA: 0x000B0BA8 File Offset: 0x000AEDA8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525001, XrefRangeEnd = 525010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17000CF7 RID: 3319
			// (get) Token: 0x06002D9A RID: 11674 RVA: 0x000B0BE4 File Offset: 0x000AEDE4
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002D9B RID: 11675 RVA: 0x000B0C24 File Offset: 0x000AEE24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 525010, XrefRangeEnd = 525015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17000CF8 RID: 3320
			// (get) Token: 0x06002D9C RID: 11676 RVA: 0x000B0C58 File Offset: 0x000AEE58
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06002D9D RID: 11677 RVA: 0x00017933 File Offset: 0x00015B33
			public _GoBackToPromptAndWait_d__12(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000CF2 RID: 3314
			// (get) Token: 0x06002D9E RID: 11678 RVA: 0x000B0C98 File Offset: 0x000AEE98
			// (set) Token: 0x06002D9F RID: 11679 RVA: 0x0001793C File Offset: 0x00015B3C
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17000CF3 RID: 3315
			// (get) Token: 0x06002DA0 RID: 11680 RVA: 0x000B0CC0 File Offset: 0x000AEEC0
			// (set) Token: 0x06002DA1 RID: 11681 RVA: 0x00017957 File Offset: 0x00015B57
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CF4 RID: 3316
			// (get) Token: 0x06002DA2 RID: 11682 RVA: 0x000B0CF0 File Offset: 0x000AEEF0
			// (set) Token: 0x06002DA3 RID: 11683 RVA: 0x00017976 File Offset: 0x00015B76
			public unsafe DBGTopLevelMenuPrompt __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGTopLevelMenuPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CF5 RID: 3317
			// (get) Token: 0x06002DA4 RID: 11684 RVA: 0x000B0D20 File Offset: 0x000AEF20
			// (set) Token: 0x06002DA5 RID: 11685 RVA: 0x00017995 File Offset: 0x00015B95
			public unsafe ModalScope scope
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12.NativeFieldInfoPtr_scope);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ModalScope>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12.NativeFieldInfoPtr_scope), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000CF6 RID: 3318
			// (get) Token: 0x06002DA6 RID: 11686 RVA: 0x000B0D50 File Offset: 0x000AEF50
			// (set) Token: 0x06002DA7 RID: 11687 RVA: 0x000179B4 File Offset: 0x00015BB4
			public unsafe IPrompt defaultPrompt
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12.NativeFieldInfoPtr_defaultPrompt);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<IPrompt>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DBGTopLevelMenuPrompt._GoBackToPromptAndWait_d__12.NativeFieldInfoPtr_defaultPrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001C40 RID: 7232
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001C41 RID: 7233
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001C42 RID: 7234
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04001C43 RID: 7235
			private static readonly IntPtr NativeFieldInfoPtr_scope;

			// Token: 0x04001C44 RID: 7236
			private static readonly IntPtr NativeFieldInfoPtr_defaultPrompt;

			// Token: 0x04001C45 RID: 7237
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001C46 RID: 7238
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001C47 RID: 7239
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001C48 RID: 7240
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001C49 RID: 7241
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001C4A RID: 7242
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
