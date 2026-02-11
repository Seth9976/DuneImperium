using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000270 RID: 624
	public class VectorImageRenderInfoPool : LinkedPool<VectorImageRenderInfo>
	{
		// Token: 0x06002E4A RID: 11850 RVA: 0x000130E5 File Offset: 0x000112E5
		// Note: this type is marked as 'beforefieldinit'.
		static VectorImageRenderInfoPool()
		{
			Il2CppClassPointerStore<VectorImageRenderInfoPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "VectorImageRenderInfoPool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VectorImageRenderInfoPool>.NativeClassPtr);
			VectorImageRenderInfoPool.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorImageRenderInfoPool>.NativeClassPtr, 100670029);
		}

		// Token: 0x06002E4B RID: 11851 RVA: 0x000C53D4 File Offset: 0x000C35D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352006, XrefRangeEnd = 352038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VectorImageRenderInfoPool()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VectorImageRenderInfoPool>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorImageRenderInfoPool.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E4C RID: 11852 RVA: 0x0001311E File Offset: 0x0001131E
		public VectorImageRenderInfoPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400214C RID: 8524
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200055D RID: 1373
		[ObfuscatedName("UnityEngine.UIElements.UIR.VectorImageRenderInfoPool+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060041EF RID: 16879 RVA: 0x001037B0 File Offset: 0x001019B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<VectorImageRenderInfoPool.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VectorImageRenderInfoPool>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VectorImageRenderInfoPool.__c>.NativeClassPtr);
				VectorImageRenderInfoPool.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorImageRenderInfoPool.__c>.NativeClassPtr, "<>9");
				VectorImageRenderInfoPool.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorImageRenderInfoPool.__c>.NativeClassPtr, "<>9__0_0");
				VectorImageRenderInfoPool.__c.NativeFieldInfoPtr___9__0_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VectorImageRenderInfoPool.__c>.NativeClassPtr, "<>9__0_1");
				VectorImageRenderInfoPool.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorImageRenderInfoPool.__c>.NativeClassPtr, 100670031);
				VectorImageRenderInfoPool.__c.NativeMethodInfoPtr___ctor_b__0_0_Internal_VectorImageRenderInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorImageRenderInfoPool.__c>.NativeClassPtr, 100670032);
				VectorImageRenderInfoPool.__c.NativeMethodInfoPtr___ctor_b__0_1_Internal_Void_VectorImageRenderInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VectorImageRenderInfoPool.__c>.NativeClassPtr, 100670033);
			}

			// Token: 0x060041F0 RID: 16880 RVA: 0x00103854 File Offset: 0x00101A54
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VectorImageRenderInfoPool.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorImageRenderInfoPool.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060041F1 RID: 16881 RVA: 0x00103890 File Offset: 0x00101A90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351999, XrefRangeEnd = 352005, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe VectorImageRenderInfo __ctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorImageRenderInfoPool.__c.NativeMethodInfoPtr___ctor_b__0_0_Internal_VectorImageRenderInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VectorImageRenderInfo>(intPtr3) : null;
			}

			// Token: 0x060041F2 RID: 16882 RVA: 0x001038D0 File Offset: 0x00101AD0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352005, XrefRangeEnd = 352006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__0_1(VectorImageRenderInfo vectorImageInfo)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(vectorImageInfo);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VectorImageRenderInfoPool.__c.NativeMethodInfoPtr___ctor_b__0_1_Internal_Void_VectorImageRenderInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060041F3 RID: 16883 RVA: 0x0001C110 File Offset: 0x0001A310
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170013C4 RID: 5060
			// (get) Token: 0x060041F4 RID: 16884 RVA: 0x00103914 File Offset: 0x00101B14
			// (set) Token: 0x060041F5 RID: 16885 RVA: 0x0001C119 File Offset: 0x0001A319
			public unsafe static VectorImageRenderInfoPool.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VectorImageRenderInfoPool.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<VectorImageRenderInfoPool.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VectorImageRenderInfoPool.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013C5 RID: 5061
			// (get) Token: 0x060041F6 RID: 16886 RVA: 0x0010393C File Offset: 0x00101B3C
			// (set) Token: 0x060041F7 RID: 16887 RVA: 0x0001C12B File Offset: 0x0001A32B
			public unsafe static Func<VectorImageRenderInfo> __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VectorImageRenderInfoPool.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<VectorImageRenderInfo>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VectorImageRenderInfoPool.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013C6 RID: 5062
			// (get) Token: 0x060041F8 RID: 16888 RVA: 0x00103964 File Offset: 0x00101B64
			// (set) Token: 0x060041F9 RID: 16889 RVA: 0x0001C13D File Offset: 0x0001A33D
			public unsafe static Action<VectorImageRenderInfo> __9__0_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(VectorImageRenderInfoPool.__c.NativeFieldInfoPtr___9__0_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<VectorImageRenderInfo>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VectorImageRenderInfoPool.__c.NativeFieldInfoPtr___9__0_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002E3C RID: 11836
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002E3D RID: 11837
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x04002E3E RID: 11838
			private static readonly IntPtr NativeFieldInfoPtr___9__0_1;

			// Token: 0x04002E3F RID: 11839
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002E40 RID: 11840
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__0_0_Internal_VectorImageRenderInfo_0;

			// Token: 0x04002E41 RID: 11841
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__0_1_Internal_Void_VectorImageRenderInfo_0;
		}

		// Token: 0x0200055E RID: 1374
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
