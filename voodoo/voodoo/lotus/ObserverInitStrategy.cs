using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace lotus
{
	// Token: 0x02000067 RID: 103
	public class ObserverInitStrategy : EntityViewInitializationStrategy
	{
		// Token: 0x0600061E RID: 1566 RVA: 0x0001DAE8 File Offset: 0x0001BCE8
		// Note: this type is marked as 'beforefieldinit'.
		static ObserverInitStrategy()
		{
			Il2CppClassPointerStore<ObserverInitStrategy>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "ObserverInitStrategy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObserverInitStrategy>.NativeClassPtr);
			ObserverInitStrategy.NativeFieldInfoPtr_observersToInit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserverInitStrategy>.NativeClassPtr, "observersToInit");
			ObserverInitStrategy.NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityView_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserverInitStrategy>.NativeClassPtr, 100664136);
			ObserverInitStrategy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserverInitStrategy>.NativeClassPtr, 100664137);
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x0001DB54 File Offset: 0x0001BD54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112812, XrefRangeEnd = 1112831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init(EntityView ec)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ec);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObserverInitStrategy.NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityView_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x0001DBA4 File Offset: 0x0001BDA4
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObserverInitStrategy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObserverInitStrategy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserverInitStrategy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00005047 File Offset: 0x00003247
		public ObserverInitStrategy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000622 RID: 1570 RVA: 0x0001DBE0 File Offset: 0x0001BDE0
		// (set) Token: 0x06000623 RID: 1571 RVA: 0x00005050 File Offset: 0x00003250
		public unsafe List<Observer> observersToInit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserverInitStrategy.NativeFieldInfoPtr_observersToInit);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Observer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserverInitStrategy.NativeFieldInfoPtr_observersToInit), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003D7 RID: 983
		private static readonly IntPtr NativeFieldInfoPtr_observersToInit;

		// Token: 0x040003D8 RID: 984
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_EntityView_0;

		// Token: 0x040003D9 RID: 985
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
