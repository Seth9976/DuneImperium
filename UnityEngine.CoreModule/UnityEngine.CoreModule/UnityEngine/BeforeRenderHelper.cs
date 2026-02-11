using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace UnityEngine
{
	// Token: 0x0200008A RID: 138
	public static class BeforeRenderHelper : Object
	{
		// Token: 0x060007B7 RID: 1975 RVA: 0x0002FA80 File Offset: 0x0002DC80
		// Note: this type is marked as 'beforefieldinit'.
		static BeforeRenderHelper()
		{
			Il2CppClassPointerStore<BeforeRenderHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "BeforeRenderHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeforeRenderHelper>.NativeClassPtr);
			BeforeRenderHelper.NativeFieldInfoPtr_s_OrderBlocks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeforeRenderHelper>.NativeClassPtr, "s_OrderBlocks");
			BeforeRenderHelper.NativeMethodInfoPtr_Invoke_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BeforeRenderHelper>.NativeClassPtr, 100664253);
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x0002FAD8 File Offset: 0x0002DCD8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 649291, RefRangeEnd = 649292, XrefRangeStart = 649273, XrefRangeEnd = 649291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Invoke()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BeforeRenderHelper.NativeMethodInfoPtr_Invoke_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00004E6A File Offset: 0x0000306A
		public BeforeRenderHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060007BA RID: 1978 RVA: 0x0002FB00 File Offset: 0x0002DD00
		// (set) Token: 0x060007BB RID: 1979 RVA: 0x00004E73 File Offset: 0x00003073
		public unsafe static List<BeforeRenderHelper.OrderBlock> s_OrderBlocks
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BeforeRenderHelper.NativeFieldInfoPtr_s_OrderBlocks, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BeforeRenderHelper.OrderBlock>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BeforeRenderHelper.NativeFieldInfoPtr_s_OrderBlocks, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x00004E85 File Offset: 0x00003085
		public static int GetUpdateOrder(UnityEngine.Events.UnityAction callback)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x00004E92 File Offset: 0x00003092
		public static void RegisterCallback(UnityEngine.Events.UnityAction callback)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00004E9F File Offset: 0x0000309F
		public static void UnregisterCallback(UnityEngine.Events.UnityAction callback)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0400065A RID: 1626
		private static readonly IntPtr NativeFieldInfoPtr_s_OrderBlocks;

		// Token: 0x0400065B RID: 1627
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Static_Void_0;

		// Token: 0x020004BA RID: 1210
		public sealed class OrderBlock : ValueType
		{
			// Token: 0x0600327A RID: 12922 RVA: 0x000B901C File Offset: 0x000B721C
			// Note: this type is marked as 'beforefieldinit'.
			static OrderBlock()
			{
				Il2CppClassPointerStore<BeforeRenderHelper.OrderBlock>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BeforeRenderHelper>.NativeClassPtr, "OrderBlock");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BeforeRenderHelper.OrderBlock>.NativeClassPtr);
				BeforeRenderHelper.OrderBlock.NativeFieldInfoPtr_order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeforeRenderHelper.OrderBlock>.NativeClassPtr, "order");
				BeforeRenderHelper.OrderBlock.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BeforeRenderHelper.OrderBlock>.NativeClassPtr, "callback");
			}

			// Token: 0x0600327B RID: 12923 RVA: 0x00013CBA File Offset: 0x00011EBA
			public OrderBlock(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0600327C RID: 12924 RVA: 0x00013CC3 File Offset: 0x00011EC3
			public OrderBlock()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BeforeRenderHelper.OrderBlock>.NativeClassPtr))
			{
			}

			// Token: 0x17000A16 RID: 2582
			// (get) Token: 0x0600327D RID: 12925 RVA: 0x000B9070 File Offset: 0x000B7270
			// (set) Token: 0x0600327E RID: 12926 RVA: 0x00013CD5 File Offset: 0x00011ED5
			public unsafe int order
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeforeRenderHelper.OrderBlock.NativeFieldInfoPtr_order);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeforeRenderHelper.OrderBlock.NativeFieldInfoPtr_order)) = value;
				}
			}

			// Token: 0x17000A17 RID: 2583
			// (get) Token: 0x0600327F RID: 12927 RVA: 0x000B9098 File Offset: 0x000B7298
			// (set) Token: 0x06003280 RID: 12928 RVA: 0x00013CF0 File Offset: 0x00011EF0
			public unsafe UnityEngine.Events.UnityAction callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeforeRenderHelper.OrderBlock.NativeFieldInfoPtr_callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEngine.Events.UnityAction>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BeforeRenderHelper.OrderBlock.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002B9B RID: 11163
			private static readonly IntPtr NativeFieldInfoPtr_order;

			// Token: 0x04002B9C RID: 11164
			private static readonly IntPtr NativeFieldInfoPtr_callback;
		}
	}
}
