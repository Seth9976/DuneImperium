using System;
using Canis;
using Canis.actions;
using Canis.actions.serialized;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace worm.canis.actions
{
	// Token: 0x02000239 RID: 569
	public class SerializedDiscard : SerializedAction
	{
		// Token: 0x060018DA RID: 6362 RVA: 0x000B9ADC File Offset: 0x000B7CDC
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedDiscard()
		{
			Il2CppClassPointerStore<SerializedDiscard>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "SerializedDiscard");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedDiscard>.NativeClassPtr);
			SerializedDiscard.NativeFieldInfoPtr_EmitSequencing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedDiscard>.NativeClassPtr, "EmitSequencing");
			SerializedDiscard.NativeFieldInfoPtr_AnalyticsData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedDiscard>.NativeClassPtr, "AnalyticsData");
			SerializedDiscard.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedDiscard>.NativeClassPtr, 100667705);
			SerializedDiscard.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedDiscard>.NativeClassPtr, 100667706);
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x000B9B5C File Offset: 0x000B7D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 134485, XrefRangeEnd = 134489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override global::Canis.actions.Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedDiscard.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Canis.actions.Action>(intPtr3) : null;
			}
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x000B9BB8 File Offset: 0x000B7DB8
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedDiscard()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedDiscard>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedDiscard.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x0000AB33 File Offset: 0x00008D33
		public SerializedDiscard(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x060018DE RID: 6366 RVA: 0x000B9BF4 File Offset: 0x000B7DF4
		// (set) Token: 0x060018DF RID: 6367 RVA: 0x0000AB3C File Offset: 0x00008D3C
		public unsafe bool EmitSequencing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedDiscard.NativeFieldInfoPtr_EmitSequencing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedDiscard.NativeFieldInfoPtr_EmitSequencing)) = value;
			}
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x060018E0 RID: 6368 RVA: 0x000B9C1C File Offset: 0x000B7E1C
		// (set) Token: 0x060018E1 RID: 6369 RVA: 0x0000AB57 File Offset: 0x00008D57
		public unsafe Dictionary<string, Object> AnalyticsData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedDiscard.NativeFieldInfoPtr_AnalyticsData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedDiscard.NativeFieldInfoPtr_AnalyticsData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F5F RID: 3935
		private static readonly IntPtr NativeFieldInfoPtr_EmitSequencing;

		// Token: 0x04000F60 RID: 3936
		private static readonly IntPtr NativeFieldInfoPtr_AnalyticsData;

		// Token: 0x04000F61 RID: 3937
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000F62 RID: 3938
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
