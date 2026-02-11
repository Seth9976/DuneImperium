using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace lotus
{
	// Token: 0x02000066 RID: 102
	public class Observer : DirtyBehaviour
	{
		// Token: 0x06000616 RID: 1558 RVA: 0x0001D938 File Offset: 0x0001BB38
		// Note: this type is marked as 'beforefieldinit'.
		static Observer()
		{
			Il2CppClassPointerStore<Observer>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "Observer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Observer>.NativeClassPtr);
			Observer.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Observer>.NativeClassPtr, "parent");
			Observer.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Observer>.NativeClassPtr, 100664132);
			Observer.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Observer>.NativeClassPtr, 100664133);
			Observer.NativeMethodInfoPtr_GetPoolable_Public_PoolableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Observer>.NativeClassPtr, 100664134);
			Observer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Observer>.NativeClassPtr, 100664135);
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x0001D9CC File Offset: 0x0001BBCC
		[CallerCount(36)]
		[CachedScanResults(RefRangeStart = 1112757, RefRangeEnd = 1112793, XrefRangeStart = 1112745, XrefRangeEnd = 1112757, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Observer.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x0001DA08 File Offset: 0x0001BC08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1112805, RefRangeEnd = 1112806, XrefRangeStart = 1112793, XrefRangeEnd = 1112805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Observer.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x0001DA3C File Offset: 0x0001BC3C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1112810, RefRangeEnd = 1112812, XrefRangeStart = 1112806, XrefRangeEnd = 1112810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PoolableItem GetPoolable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Observer.NativeMethodInfoPtr_GetPoolable_Public_PoolableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PoolableItem>(intPtr3) : null;
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x0001DA7C File Offset: 0x0001BC7C
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Observer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Observer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Observer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x0000501F File Offset: 0x0000321F
		public Observer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x0001DAB8 File Offset: 0x0001BCB8
		// (set) Token: 0x0600061D RID: 1565 RVA: 0x00005028 File Offset: 0x00003228
		public unsafe EntityView parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Observer.NativeFieldInfoPtr_parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Observer.NativeFieldInfoPtr_parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040003D4 RID: 980
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

		// Token: 0x040003D5 RID: 981
		private static readonly IntPtr NativeMethodInfoPtr_GetPoolable_Public_PoolableItem_0;

		// Token: 0x040003D6 RID: 982
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
