using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using TMPro;
using zen.src.menus;

namespace boardgames.menus
{
	// Token: 0x0200014E RID: 334
	public class ConfirmOrCancelDialog : DialogRenderer
	{
		// Token: 0x0600111B RID: 4379 RVA: 0x0004596C File Offset: 0x00043B6C
		// Note: this type is marked as 'beforefieldinit'.
		static ConfirmOrCancelDialog()
		{
			Il2CppClassPointerStore<ConfirmOrCancelDialog>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "boardgames.menus", "ConfirmOrCancelDialog");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfirmOrCancelDialog>.NativeClassPtr);
			ConfirmOrCancelDialog.NativeFieldInfoPtr_DefaultConfirmKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmOrCancelDialog>.NativeClassPtr, "DefaultConfirmKey");
			ConfirmOrCancelDialog.NativeFieldInfoPtr_DefaultCancelKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmOrCancelDialog>.NativeClassPtr, "DefaultCancelKey");
			ConfirmOrCancelDialog.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmOrCancelDialog>.NativeClassPtr, "message");
			ConfirmOrCancelDialog.NativeFieldInfoPtr_confirmButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmOrCancelDialog>.NativeClassPtr, "confirmButtonLabel");
			ConfirmOrCancelDialog.NativeFieldInfoPtr_cancelButtonLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmOrCancelDialog>.NativeClassPtr, "cancelButtonLabel");
			ConfirmOrCancelDialog.NativeFieldInfoPtr__Result_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmOrCancelDialog>.NativeClassPtr, "<Result>k__BackingField");
			ConfirmOrCancelDialog.NativeMethodInfoPtr_get_Result_Public_get_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOrCancelDialog>.NativeClassPtr, 100665813);
			ConfirmOrCancelDialog.NativeMethodInfoPtr_set_Result_Private_set_Void_Nullable_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOrCancelDialog>.NativeClassPtr, 100665814);
			ConfirmOrCancelDialog.NativeMethodInfoPtr_WithMessage_Public_ConfirmOrCancelDialog_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOrCancelDialog>.NativeClassPtr, 100665815);
			ConfirmOrCancelDialog.NativeMethodInfoPtr_Show_Public_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOrCancelDialog>.NativeClassPtr, 100665816);
			ConfirmOrCancelDialog.NativeMethodInfoPtr_Event_Confirm_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOrCancelDialog>.NativeClassPtr, 100665817);
			ConfirmOrCancelDialog.NativeMethodInfoPtr_Event_Cancel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOrCancelDialog>.NativeClassPtr, 100665818);
			ConfirmOrCancelDialog.NativeMethodInfoPtr_ShowUntilResolved_Public_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOrCancelDialog>.NativeClassPtr, 100665819);
			ConfirmOrCancelDialog.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOrCancelDialog>.NativeClassPtr, 100665820);
			ConfirmOrCancelDialog.NativeMethodInfoPtr___n__0_Private_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOrCancelDialog>.NativeClassPtr, 100665821);
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x0600111C RID: 4380 RVA: 0x00045AC8 File Offset: 0x00043CC8
		// (set) Token: 0x0600111D RID: 4381 RVA: 0x00045B00 File Offset: 0x00043D00
		public unsafe Nullable<bool> Result
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOrCancelDialog.NativeMethodInfoPtr_get_Result_Public_get_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new Nullable<bool>(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOrCancelDialog.NativeMethodInfoPtr_set_Result_Private_set_Void_Nullable_1_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x00045B48 File Offset: 0x00043D48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999826, XrefRangeEnd = 999837, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfirmOrCancelDialog WithMessage(string message, string confirmLabel = null, string cancelLabel = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(confirmLabel);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(cancelLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOrCancelDialog.NativeMethodInfoPtr_WithMessage_Public_ConfirmOrCancelDialog_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfirmOrCancelDialog>(intPtr3) : null;
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x00045BBC File Offset: 0x00043DBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999837, XrefRangeEnd = 999842, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator Show()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConfirmOrCancelDialog.NativeMethodInfoPtr_Show_Public_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x00045C08 File Offset: 0x00043E08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999842, XrefRangeEnd = 999846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Confirm()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOrCancelDialog.NativeMethodInfoPtr_Event_Confirm_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x00045C3C File Offset: 0x00043E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999846, XrefRangeEnd = 999850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Event_Cancel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOrCancelDialog.NativeMethodInfoPtr_Event_Cancel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x00045C70 File Offset: 0x00043E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999850, XrefRangeEnd = 999855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ShowUntilResolved()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOrCancelDialog.NativeMethodInfoPtr_ShowUntilResolved_Public_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x00045CB0 File Offset: 0x00043EB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999855, XrefRangeEnd = 999856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfirmOrCancelDialog()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfirmOrCancelDialog>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOrCancelDialog.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x00045CEC File Offset: 0x00043EEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999856, XrefRangeEnd = 999857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator __n__0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOrCancelDialog.NativeMethodInfoPtr___n__0_Private_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x00009F56 File Offset: 0x00008156
		public ConfirmOrCancelDialog(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06001126 RID: 4390 RVA: 0x00045D2C File Offset: 0x00043F2C
		// (set) Token: 0x06001127 RID: 4391 RVA: 0x00009F5F File Offset: 0x0000815F
		public unsafe static string DefaultConfirmKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ConfirmOrCancelDialog.NativeFieldInfoPtr_DefaultConfirmKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConfirmOrCancelDialog.NativeFieldInfoPtr_DefaultConfirmKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06001128 RID: 4392 RVA: 0x00045D4C File Offset: 0x00043F4C
		// (set) Token: 0x06001129 RID: 4393 RVA: 0x00009F71 File Offset: 0x00008171
		public unsafe static string DefaultCancelKey
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ConfirmOrCancelDialog.NativeFieldInfoPtr_DefaultCancelKey, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConfirmOrCancelDialog.NativeFieldInfoPtr_DefaultCancelKey, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x0600112A RID: 4394 RVA: 0x00045D6C File Offset: 0x00043F6C
		// (set) Token: 0x0600112B RID: 4395 RVA: 0x00009F83 File Offset: 0x00008183
		public unsafe TMP_Text message
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOrCancelDialog.NativeFieldInfoPtr_message);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOrCancelDialog.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x0600112C RID: 4396 RVA: 0x00045D9C File Offset: 0x00043F9C
		// (set) Token: 0x0600112D RID: 4397 RVA: 0x00009FA2 File Offset: 0x000081A2
		public unsafe TMP_Text confirmButtonLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOrCancelDialog.NativeFieldInfoPtr_confirmButtonLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOrCancelDialog.NativeFieldInfoPtr_confirmButtonLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x0600112E RID: 4398 RVA: 0x00045DCC File Offset: 0x00043FCC
		// (set) Token: 0x0600112F RID: 4399 RVA: 0x00009FC1 File Offset: 0x000081C1
		public unsafe TMP_Text cancelButtonLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOrCancelDialog.NativeFieldInfoPtr_cancelButtonLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOrCancelDialog.NativeFieldInfoPtr_cancelButtonLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06001130 RID: 4400 RVA: 0x00045DFC File Offset: 0x00043FFC
		// (set) Token: 0x06001131 RID: 4401 RVA: 0x00009FE0 File Offset: 0x000081E0
		public Nullable<bool> _Result_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOrCancelDialog.NativeFieldInfoPtr__Result_k__BackingField);
				return new Nullable<bool>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOrCancelDialog.NativeFieldInfoPtr__Result_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<bool>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000A69 RID: 2665
		private static readonly IntPtr NativeFieldInfoPtr_DefaultConfirmKey;

		// Token: 0x04000A6A RID: 2666
		private static readonly IntPtr NativeFieldInfoPtr_DefaultCancelKey;

		// Token: 0x04000A6B RID: 2667
		private static readonly IntPtr NativeFieldInfoPtr_message;

		// Token: 0x04000A6C RID: 2668
		private static readonly IntPtr NativeFieldInfoPtr_confirmButtonLabel;

		// Token: 0x04000A6D RID: 2669
		private static readonly IntPtr NativeFieldInfoPtr_cancelButtonLabel;

		// Token: 0x04000A6E RID: 2670
		private static readonly IntPtr NativeFieldInfoPtr__Result_k__BackingField;

		// Token: 0x04000A6F RID: 2671
		private static readonly IntPtr NativeMethodInfoPtr_get_Result_Public_get_Nullable_1_Boolean_0;

		// Token: 0x04000A70 RID: 2672
		private static readonly IntPtr NativeMethodInfoPtr_set_Result_Private_set_Void_Nullable_1_Boolean_0;

		// Token: 0x04000A71 RID: 2673
		private static readonly IntPtr NativeMethodInfoPtr_WithMessage_Public_ConfirmOrCancelDialog_String_String_String_0;

		// Token: 0x04000A72 RID: 2674
		private static readonly IntPtr NativeMethodInfoPtr_Show_Public_Virtual_IEnumerator_0;

		// Token: 0x04000A73 RID: 2675
		private static readonly IntPtr NativeMethodInfoPtr_Event_Confirm_Public_Void_0;

		// Token: 0x04000A74 RID: 2676
		private static readonly IntPtr NativeMethodInfoPtr_Event_Cancel_Public_Void_0;

		// Token: 0x04000A75 RID: 2677
		private static readonly IntPtr NativeMethodInfoPtr_ShowUntilResolved_Public_IEnumerator_0;

		// Token: 0x04000A76 RID: 2678
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000A77 RID: 2679
		private static readonly IntPtr NativeMethodInfoPtr___n__0_Private_IEnumerator_0;

		// Token: 0x0200027C RID: 636
		[ObfuscatedName("boardgames.menus.ConfirmOrCancelDialog+<Show>d__10")]
		public sealed class _Show_d__10 : Object
		{
			// Token: 0x06001D52 RID: 7506 RVA: 0x0006B848 File Offset: 0x00069A48
			// Note: this type is marked as 'beforefieldinit'.
			static _Show_d__10()
			{
				Il2CppClassPointerStore<ConfirmOrCancelDialog._Show_d__10>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfirmOrCancelDialog>.NativeClassPtr, "<Show>d__10");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfirmOrCancelDialog._Show_d__10>.NativeClassPtr);
				ConfirmOrCancelDialog._Show_d__10.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmOrCancelDialog._Show_d__10>.NativeClassPtr, "<>1__state");
				ConfirmOrCancelDialog._Show_d__10.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmOrCancelDialog._Show_d__10>.NativeClassPtr, "<>2__current");
				ConfirmOrCancelDialog._Show_d__10.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmOrCancelDialog._Show_d__10>.NativeClassPtr, "<>4__this");
				ConfirmOrCancelDialog._Show_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOrCancelDialog._Show_d__10>.NativeClassPtr, 100665822);
				ConfirmOrCancelDialog._Show_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOrCancelDialog._Show_d__10>.NativeClassPtr, 100665823);
				ConfirmOrCancelDialog._Show_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOrCancelDialog._Show_d__10>.NativeClassPtr, 100665824);
				ConfirmOrCancelDialog._Show_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOrCancelDialog._Show_d__10>.NativeClassPtr, 100665825);
				ConfirmOrCancelDialog._Show_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOrCancelDialog._Show_d__10>.NativeClassPtr, 100665826);
				ConfirmOrCancelDialog._Show_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOrCancelDialog._Show_d__10>.NativeClassPtr, 100665827);
			}

			// Token: 0x06001D53 RID: 7507 RVA: 0x0006B928 File Offset: 0x00069B28
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _Show_d__10(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfirmOrCancelDialog._Show_d__10>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOrCancelDialog._Show_d__10.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D54 RID: 7508 RVA: 0x0006B970 File Offset: 0x00069B70
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOrCancelDialog._Show_d__10.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D55 RID: 7509 RVA: 0x0006B9A4 File Offset: 0x00069BA4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999813, XrefRangeEnd = 999815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOrCancelDialog._Show_d__10.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170008BE RID: 2238
			// (get) Token: 0x06001D56 RID: 7510 RVA: 0x0006B9E0 File Offset: 0x00069BE0
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOrCancelDialog._Show_d__10.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001D57 RID: 7511 RVA: 0x0006BA20 File Offset: 0x00069C20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999815, XrefRangeEnd = 999820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOrCancelDialog._Show_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170008BF RID: 2239
			// (get) Token: 0x06001D58 RID: 7512 RVA: 0x0006BA54 File Offset: 0x00069C54
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOrCancelDialog._Show_d__10.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001D59 RID: 7513 RVA: 0x0000FC4B File Offset: 0x0000DE4B
			public _Show_d__10(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008BB RID: 2235
			// (get) Token: 0x06001D5A RID: 7514 RVA: 0x0006BA94 File Offset: 0x00069C94
			// (set) Token: 0x06001D5B RID: 7515 RVA: 0x0000FC54 File Offset: 0x0000DE54
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOrCancelDialog._Show_d__10.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOrCancelDialog._Show_d__10.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008BC RID: 2236
			// (get) Token: 0x06001D5C RID: 7516 RVA: 0x0006BABC File Offset: 0x00069CBC
			// (set) Token: 0x06001D5D RID: 7517 RVA: 0x0000FC6F File Offset: 0x0000DE6F
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOrCancelDialog._Show_d__10.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOrCancelDialog._Show_d__10.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008BD RID: 2237
			// (get) Token: 0x06001D5E RID: 7518 RVA: 0x0006BAEC File Offset: 0x00069CEC
			// (set) Token: 0x06001D5F RID: 7519 RVA: 0x0000FC8E File Offset: 0x0000DE8E
			public unsafe ConfirmOrCancelDialog __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOrCancelDialog._Show_d__10.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmOrCancelDialog>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOrCancelDialog._Show_d__10.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040011D8 RID: 4568
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040011D9 RID: 4569
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040011DA RID: 4570
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040011DB RID: 4571
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040011DC RID: 4572
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040011DD RID: 4573
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040011DE RID: 4574
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040011DF RID: 4575
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040011E0 RID: 4576
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200027D RID: 637
		[ObfuscatedName("boardgames.menus.ConfirmOrCancelDialog+<ShowUntilResolved>d__13")]
		public sealed class _ShowUntilResolved_d__13 : Object
		{
			// Token: 0x06001D60 RID: 7520 RVA: 0x0006BB1C File Offset: 0x00069D1C
			// Note: this type is marked as 'beforefieldinit'.
			static _ShowUntilResolved_d__13()
			{
				Il2CppClassPointerStore<ConfirmOrCancelDialog._ShowUntilResolved_d__13>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConfirmOrCancelDialog>.NativeClassPtr, "<ShowUntilResolved>d__13");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfirmOrCancelDialog._ShowUntilResolved_d__13>.NativeClassPtr);
				ConfirmOrCancelDialog._ShowUntilResolved_d__13.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmOrCancelDialog._ShowUntilResolved_d__13>.NativeClassPtr, "<>1__state");
				ConfirmOrCancelDialog._ShowUntilResolved_d__13.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmOrCancelDialog._ShowUntilResolved_d__13>.NativeClassPtr, "<>2__current");
				ConfirmOrCancelDialog._ShowUntilResolved_d__13.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfirmOrCancelDialog._ShowUntilResolved_d__13>.NativeClassPtr, "<>4__this");
				ConfirmOrCancelDialog._ShowUntilResolved_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOrCancelDialog._ShowUntilResolved_d__13>.NativeClassPtr, 100665828);
				ConfirmOrCancelDialog._ShowUntilResolved_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOrCancelDialog._ShowUntilResolved_d__13>.NativeClassPtr, 100665829);
				ConfirmOrCancelDialog._ShowUntilResolved_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOrCancelDialog._ShowUntilResolved_d__13>.NativeClassPtr, 100665830);
				ConfirmOrCancelDialog._ShowUntilResolved_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOrCancelDialog._ShowUntilResolved_d__13>.NativeClassPtr, 100665831);
				ConfirmOrCancelDialog._ShowUntilResolved_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOrCancelDialog._ShowUntilResolved_d__13>.NativeClassPtr, 100665832);
				ConfirmOrCancelDialog._ShowUntilResolved_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfirmOrCancelDialog._ShowUntilResolved_d__13>.NativeClassPtr, 100665833);
			}

			// Token: 0x06001D61 RID: 7521 RVA: 0x0006BBFC File Offset: 0x00069DFC
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ShowUntilResolved_d__13(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfirmOrCancelDialog._ShowUntilResolved_d__13>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOrCancelDialog._ShowUntilResolved_d__13.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001D62 RID: 7522 RVA: 0x0006BC44 File Offset: 0x00069E44
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOrCancelDialog._ShowUntilResolved_d__13.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D63 RID: 7523 RVA: 0x0006BC78 File Offset: 0x00069E78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999820, XrefRangeEnd = 999821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOrCancelDialog._ShowUntilResolved_d__13.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170008C3 RID: 2243
			// (get) Token: 0x06001D64 RID: 7524 RVA: 0x0006BCB4 File Offset: 0x00069EB4
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOrCancelDialog._ShowUntilResolved_d__13.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001D65 RID: 7525 RVA: 0x0006BCF4 File Offset: 0x00069EF4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 999821, XrefRangeEnd = 999826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOrCancelDialog._ShowUntilResolved_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170008C4 RID: 2244
			// (get) Token: 0x06001D66 RID: 7526 RVA: 0x0006BD28 File Offset: 0x00069F28
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfirmOrCancelDialog._ShowUntilResolved_d__13.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001D67 RID: 7527 RVA: 0x0000FCAD File Offset: 0x0000DEAD
			public _ShowUntilResolved_d__13(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170008C0 RID: 2240
			// (get) Token: 0x06001D68 RID: 7528 RVA: 0x0006BD68 File Offset: 0x00069F68
			// (set) Token: 0x06001D69 RID: 7529 RVA: 0x0000FCB6 File Offset: 0x0000DEB6
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOrCancelDialog._ShowUntilResolved_d__13.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOrCancelDialog._ShowUntilResolved_d__13.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170008C1 RID: 2241
			// (get) Token: 0x06001D6A RID: 7530 RVA: 0x0006BD90 File Offset: 0x00069F90
			// (set) Token: 0x06001D6B RID: 7531 RVA: 0x0000FCD1 File Offset: 0x0000DED1
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOrCancelDialog._ShowUntilResolved_d__13.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOrCancelDialog._ShowUntilResolved_d__13.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170008C2 RID: 2242
			// (get) Token: 0x06001D6C RID: 7532 RVA: 0x0006BDC0 File Offset: 0x00069FC0
			// (set) Token: 0x06001D6D RID: 7533 RVA: 0x0000FCF0 File Offset: 0x0000DEF0
			public unsafe ConfirmOrCancelDialog __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOrCancelDialog._ShowUntilResolved_d__13.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfirmOrCancelDialog>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfirmOrCancelDialog._ShowUntilResolved_d__13.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040011E1 RID: 4577
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040011E2 RID: 4578
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040011E3 RID: 4579
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040011E4 RID: 4580
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040011E5 RID: 4581
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040011E6 RID: 4582
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040011E7 RID: 4583
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040011E8 RID: 4584
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040011E9 RID: 4585
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
