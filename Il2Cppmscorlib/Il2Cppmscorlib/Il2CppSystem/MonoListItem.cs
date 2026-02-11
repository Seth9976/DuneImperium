using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200015B RID: 347
	public sealed class MonoListItem : Object
	{
		// Token: 0x0600179F RID: 6047 RVA: 0x000966A0 File Offset: 0x000948A0
		// Note: this type is marked as 'beforefieldinit'.
		static MonoListItem()
		{
			Il2CppClassPointerStore<MonoListItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MonoListItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoListItem>.NativeClassPtr);
			MonoListItem.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoListItem>.NativeClassPtr, "next");
			MonoListItem.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoListItem>.NativeClassPtr, "data");
			MonoListItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoListItem>.NativeClassPtr, 100667426);
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x0009670C File Offset: 0x0009490C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoListItem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoListItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoListItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x000077A5 File Offset: 0x000059A5
		public MonoListItem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x060017A2 RID: 6050 RVA: 0x00096748 File Offset: 0x00094948
		// (set) Token: 0x060017A3 RID: 6051 RVA: 0x000077AE File Offset: 0x000059AE
		public unsafe MonoListItem next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoListItem.NativeFieldInfoPtr_next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoListItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoListItem.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x060017A4 RID: 6052 RVA: 0x00096778 File Offset: 0x00094978
		// (set) Token: 0x060017A5 RID: 6053 RVA: 0x000077CD File Offset: 0x000059CD
		public unsafe Object data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoListItem.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoListItem.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001448 RID: 5192
		private static readonly IntPtr NativeFieldInfoPtr_next;

		// Token: 0x04001449 RID: 5193
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x0400144A RID: 5194
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
