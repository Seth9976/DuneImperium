using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200012D RID: 301
	public class DefaultExecutionOrder : Attribute
	{
		// Token: 0x060017B0 RID: 6064 RVA: 0x000701E8 File Offset: 0x0006E3E8
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultExecutionOrder()
		{
			Il2CppClassPointerStore<DefaultExecutionOrder>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "DefaultExecutionOrder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultExecutionOrder>.NativeClassPtr);
			DefaultExecutionOrder.NativeFieldInfoPtr_m_Order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultExecutionOrder>.NativeClassPtr, "m_Order");
			DefaultExecutionOrder.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultExecutionOrder>.NativeClassPtr, 100666530);
			DefaultExecutionOrder.NativeMethodInfoPtr_get_order_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultExecutionOrder>.NativeClassPtr, 100666531);
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x00070254 File Offset: 0x0006E454
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 346333, RefRangeEnd = 346361, XrefRangeStart = 346333, XrefRangeEnd = 346361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultExecutionOrder(int order)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultExecutionOrder>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref order;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultExecutionOrder.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x060017B2 RID: 6066 RVA: 0x0007029C File Offset: 0x0006E49C
		public unsafe int order
		{
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 334600, RefRangeEnd = 334642, XrefRangeStart = 334600, XrefRangeEnd = 334642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultExecutionOrder.NativeMethodInfoPtr_get_order_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060017B3 RID: 6067 RVA: 0x00009656 File Offset: 0x00007856
		public DefaultExecutionOrder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x060017B4 RID: 6068 RVA: 0x000702D8 File Offset: 0x0006E4D8
		// (set) Token: 0x060017B5 RID: 6069 RVA: 0x0000965F File Offset: 0x0000785F
		public unsafe int m_Order
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultExecutionOrder.NativeFieldInfoPtr_m_Order);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultExecutionOrder.NativeFieldInfoPtr_m_Order)) = value;
			}
		}

		// Token: 0x04001556 RID: 5462
		private static readonly IntPtr NativeFieldInfoPtr_m_Order;

		// Token: 0x04001557 RID: 5463
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x04001558 RID: 5464
		private static readonly IntPtr NativeMethodInfoPtr_get_order_Public_get_Int32_0;
	}
}
