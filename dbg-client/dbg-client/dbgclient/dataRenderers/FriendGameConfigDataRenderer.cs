using System;
using dbgclient.data;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using TMPro;
using UnityEngine;

namespace dbgclient.dataRenderers
{
	// Token: 0x020000B7 RID: 183
	public class FriendGameConfigDataRenderer : VersionedSubscriber<FriendGameConfigData>
	{
		// Token: 0x0600077D RID: 1917 RVA: 0x00034FFC File Offset: 0x000331FC
		// Note: this type is marked as 'beforefieldinit'.
		static FriendGameConfigDataRenderer()
		{
			Il2CppClassPointerStore<FriendGameConfigDataRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.dataRenderers", "FriendGameConfigDataRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendGameConfigDataRenderer>.NativeClassPtr);
			FriendGameConfigDataRenderer.NativeFieldInfoPtr_slots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameConfigDataRenderer>.NativeClassPtr, "slots");
			FriendGameConfigDataRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameConfigDataRenderer>.NativeClassPtr, 100664425);
			FriendGameConfigDataRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FriendGameConfigDataRenderer>.NativeClassPtr, 100664426);
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00035068 File Offset: 0x00033268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504267, XrefRangeEnd = 504286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FriendGameConfigDataRenderer.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x000350A4 File Offset: 0x000332A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 504286, XrefRangeEnd = 504296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FriendGameConfigDataRenderer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendGameConfigDataRenderer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FriendGameConfigDataRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x000057BD File Offset: 0x000039BD
		public FriendGameConfigDataRenderer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000781 RID: 1921 RVA: 0x000350E0 File Offset: 0x000332E0
		// (set) Token: 0x06000782 RID: 1922 RVA: 0x000057C6 File Offset: 0x000039C6
		public unsafe Il2CppReferenceArray<FriendGameConfigDataRenderer.FriendSlot> slots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameConfigDataRenderer.NativeFieldInfoPtr_slots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FriendGameConfigDataRenderer.FriendSlot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameConfigDataRenderer.NativeFieldInfoPtr_slots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000493 RID: 1171
		private static readonly IntPtr NativeFieldInfoPtr_slots;

		// Token: 0x04000494 RID: 1172
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

		// Token: 0x04000495 RID: 1173
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200031E RID: 798
		[Serializable]
		public sealed class FriendSlot : ValueType
		{
			// Token: 0x060025A7 RID: 9639 RVA: 0x000991C8 File Offset: 0x000973C8
			// Note: this type is marked as 'beforefieldinit'.
			static FriendSlot()
			{
				Il2CppClassPointerStore<FriendGameConfigDataRenderer.FriendSlot>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FriendGameConfigDataRenderer>.NativeClassPtr, "FriendSlot");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FriendGameConfigDataRenderer.FriendSlot>.NativeClassPtr);
				FriendGameConfigDataRenderer.FriendSlot.NativeFieldInfoPtr_textField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameConfigDataRenderer.FriendSlot>.NativeClassPtr, "textField");
				FriendGameConfigDataRenderer.FriendSlot.NativeFieldInfoPtr_addButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameConfigDataRenderer.FriendSlot>.NativeClassPtr, "addButton");
				FriendGameConfigDataRenderer.FriendSlot.NativeFieldInfoPtr_removeButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FriendGameConfigDataRenderer.FriendSlot>.NativeClassPtr, "removeButton");
			}

			// Token: 0x060025A8 RID: 9640 RVA: 0x000138B3 File Offset: 0x00011AB3
			public FriendSlot(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x060025A9 RID: 9641 RVA: 0x000138BC File Offset: 0x00011ABC
			public FriendSlot()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FriendGameConfigDataRenderer.FriendSlot>.NativeClassPtr))
			{
			}

			// Token: 0x17000A60 RID: 2656
			// (get) Token: 0x060025AA RID: 9642 RVA: 0x00099230 File Offset: 0x00097430
			// (set) Token: 0x060025AB RID: 9643 RVA: 0x000138CE File Offset: 0x00011ACE
			public unsafe TMP_Text textField
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameConfigDataRenderer.FriendSlot.NativeFieldInfoPtr_textField);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameConfigDataRenderer.FriendSlot.NativeFieldInfoPtr_textField), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A61 RID: 2657
			// (get) Token: 0x060025AC RID: 9644 RVA: 0x00099260 File Offset: 0x00097460
			// (set) Token: 0x060025AD RID: 9645 RVA: 0x000138ED File Offset: 0x00011AED
			public unsafe GameObject addButton
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameConfigDataRenderer.FriendSlot.NativeFieldInfoPtr_addButton);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameConfigDataRenderer.FriendSlot.NativeFieldInfoPtr_addButton), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A62 RID: 2658
			// (get) Token: 0x060025AE RID: 9646 RVA: 0x00099290 File Offset: 0x00097490
			// (set) Token: 0x060025AF RID: 9647 RVA: 0x0001390C File Offset: 0x00011B0C
			public unsafe GameObject removeButton
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameConfigDataRenderer.FriendSlot.NativeFieldInfoPtr_removeButton);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FriendGameConfigDataRenderer.FriendSlot.NativeFieldInfoPtr_removeButton), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017A1 RID: 6049
			private static readonly IntPtr NativeFieldInfoPtr_textField;

			// Token: 0x040017A2 RID: 6050
			private static readonly IntPtr NativeFieldInfoPtr_addButton;

			// Token: 0x040017A3 RID: 6051
			private static readonly IntPtr NativeFieldInfoPtr_removeButton;
		}
	}
}
