using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Unity.Collections;

namespace UnityEngine
{
	// Token: 0x02000105 RID: 261
	public sealed class TypeDispatchData : ValueType
	{
		// Token: 0x060015E8 RID: 5608 RVA: 0x0006B14C File Offset: 0x0006934C
		// Note: this type is marked as 'beforefieldinit'.
		static TypeDispatchData()
		{
			Il2CppClassPointerStore<TypeDispatchData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "TypeDispatchData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeDispatchData>.NativeClassPtr);
			TypeDispatchData.NativeFieldInfoPtr_changed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDispatchData>.NativeClassPtr, "changed");
			TypeDispatchData.NativeFieldInfoPtr_changedID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDispatchData>.NativeClassPtr, "changedID");
			TypeDispatchData.NativeFieldInfoPtr_destroyedID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDispatchData>.NativeClassPtr, "destroyedID");
			TypeDispatchData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDispatchData>.NativeClassPtr, 100666370);
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x0006B1CC File Offset: 0x000693CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 659907, XrefRangeEnd = 659913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDispatchData.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x000087D0 File Offset: 0x000069D0
		public TypeDispatchData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x000087D9 File Offset: 0x000069D9
		public TypeDispatchData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeDispatchData>.NativeClassPtr))
		{
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x060015EC RID: 5612 RVA: 0x0006B204 File Offset: 0x00069404
		// (set) Token: 0x060015ED RID: 5613 RVA: 0x000087EB File Offset: 0x000069EB
		public unsafe Il2CppReferenceArray<Object> changed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDispatchData.NativeFieldInfoPtr_changed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDispatchData.NativeFieldInfoPtr_changed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x060015EE RID: 5614 RVA: 0x0006B234 File Offset: 0x00069434
		// (set) Token: 0x060015EF RID: 5615 RVA: 0x0000880A File Offset: 0x00006A0A
		public Unity.Collections.NativeArray<int> changedID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDispatchData.NativeFieldInfoPtr_changedID);
				return new Unity.Collections.NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.NativeArray<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDispatchData.NativeFieldInfoPtr_changedID), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.NativeArray<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x060015F0 RID: 5616 RVA: 0x0006B264 File Offset: 0x00069464
		// (set) Token: 0x060015F1 RID: 5617 RVA: 0x00008838 File Offset: 0x00006A38
		public Unity.Collections.NativeArray<int> destroyedID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDispatchData.NativeFieldInfoPtr_destroyedID);
				return new Unity.Collections.NativeArray<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Unity.Collections.NativeArray<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDispatchData.NativeFieldInfoPtr_destroyedID), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Unity.Collections.NativeArray<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04001467 RID: 5223
		private static readonly IntPtr NativeFieldInfoPtr_changed;

		// Token: 0x04001468 RID: 5224
		private static readonly IntPtr NativeFieldInfoPtr_changedID;

		// Token: 0x04001469 RID: 5225
		private static readonly IntPtr NativeFieldInfoPtr_destroyedID;

		// Token: 0x0400146A RID: 5226
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
	}
}
