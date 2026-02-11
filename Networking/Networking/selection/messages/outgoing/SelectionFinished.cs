using System;
using Canis.messages;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Networking.selection.messages.outgoing
{
	// Token: 0x0200008A RID: 138
	public class SelectionFinished : GameMessage
	{
		// Token: 0x060004A1 RID: 1185 RVA: 0x000125D0 File Offset: 0x000107D0
		// Note: this type is marked as 'beforefieldinit'.
		static SelectionFinished()
		{
			Il2CppClassPointerStore<SelectionFinished>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.messages.outgoing", "SelectionFinished");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectionFinished>.NativeClassPtr);
			SelectionFinished.NativeFieldInfoPtr__PlayerAccountID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectionFinished>.NativeClassPtr, "<PlayerAccountID>k__BackingField");
			SelectionFinished.NativeMethodInfoPtr_get_PlayerAccountID_Public_Virtual_Final_New_get_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFinished>.NativeClassPtr, 100663601);
			SelectionFinished.NativeMethodInfoPtr_set_PlayerAccountID_Public_Virtual_Final_New_set_Void_AccountID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFinished>.NativeClassPtr, 100663602);
			SelectionFinished.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectionFinished>.NativeClassPtr, 100663603);
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x00012650 File Offset: 0x00010850
		// (set) Token: 0x060004A3 RID: 1187 RVA: 0x00012690 File Offset: 0x00010890
		public unsafe virtual AccountID PlayerAccountID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionFinished.NativeMethodInfoPtr_get_PlayerAccountID_Public_Virtual_Final_New_get_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionFinished.NativeMethodInfoPtr_set_PlayerAccountID_Public_Virtual_Final_New_set_Void_AccountID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x000126D4 File Offset: 0x000108D4
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectionFinished()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectionFinished>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectionFinished.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00004D87 File Offset: 0x00002F87
		public SelectionFinished(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x00012710 File Offset: 0x00010910
		// (set) Token: 0x060004A7 RID: 1191 RVA: 0x00004D90 File Offset: 0x00002F90
		public unsafe AccountID _PlayerAccountID_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionFinished.NativeFieldInfoPtr__PlayerAccountID_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AccountID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectionFinished.NativeFieldInfoPtr__PlayerAccountID_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000284 RID: 644
		private static readonly IntPtr NativeFieldInfoPtr__PlayerAccountID_k__BackingField;

		// Token: 0x04000285 RID: 645
		private static readonly IntPtr NativeMethodInfoPtr_get_PlayerAccountID_Public_Virtual_Final_New_get_AccountID_0;

		// Token: 0x04000286 RID: 646
		private static readonly IntPtr NativeMethodInfoPtr_set_PlayerAccountID_Public_Virtual_Final_New_set_Void_AccountID_0;

		// Token: 0x04000287 RID: 647
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
