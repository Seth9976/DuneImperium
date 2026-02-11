using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000272 RID: 626
	public class GradientRemapPool : LinkedPool<GradientRemap>
	{
		// Token: 0x06002E57 RID: 11863 RVA: 0x00013198 File Offset: 0x00011398
		// Note: this type is marked as 'beforefieldinit'.
		static GradientRemapPool()
		{
			Il2CppClassPointerStore<GradientRemapPool>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "GradientRemapPool");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GradientRemapPool>.NativeClassPtr);
			GradientRemapPool.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientRemapPool>.NativeClassPtr, 100670036);
		}

		// Token: 0x06002E58 RID: 11864 RVA: 0x000C559C File Offset: 0x000C379C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352052, XrefRangeEnd = 352084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GradientRemapPool()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GradientRemapPool>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientRemapPool.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E59 RID: 11865 RVA: 0x000131D1 File Offset: 0x000113D1
		public GradientRemapPool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002152 RID: 8530
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200055F RID: 1375
		[ObfuscatedName("UnityEngine.UIElements.UIR.GradientRemapPool+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060041FA RID: 16890 RVA: 0x0010398C File Offset: 0x00101B8C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GradientRemapPool.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GradientRemapPool>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GradientRemapPool.__c>.NativeClassPtr);
				GradientRemapPool.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientRemapPool.__c>.NativeClassPtr, "<>9");
				GradientRemapPool.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientRemapPool.__c>.NativeClassPtr, "<>9__0_0");
				GradientRemapPool.__c.NativeFieldInfoPtr___9__0_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GradientRemapPool.__c>.NativeClassPtr, "<>9__0_1");
				GradientRemapPool.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientRemapPool.__c>.NativeClassPtr, 100670038);
				GradientRemapPool.__c.NativeMethodInfoPtr___ctor_b__0_0_Internal_GradientRemap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientRemapPool.__c>.NativeClassPtr, 100670039);
				GradientRemapPool.__c.NativeMethodInfoPtr___ctor_b__0_1_Internal_Void_GradientRemap_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GradientRemapPool.__c>.NativeClassPtr, 100670040);
			}

			// Token: 0x060041FB RID: 16891 RVA: 0x00103A30 File Offset: 0x00101C30
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GradientRemapPool.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientRemapPool.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060041FC RID: 16892 RVA: 0x00103A6C File Offset: 0x00101C6C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352042, XrefRangeEnd = 352048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GradientRemap __ctor_b__0_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientRemapPool.__c.NativeMethodInfoPtr___ctor_b__0_0_Internal_GradientRemap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<GradientRemap>(intPtr3) : null;
			}

			// Token: 0x060041FD RID: 16893 RVA: 0x00103AAC File Offset: 0x00101CAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 352048, XrefRangeEnd = 352052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __ctor_b__0_1(GradientRemap gradientRemap)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(gradientRemap);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GradientRemapPool.__c.NativeMethodInfoPtr___ctor_b__0_1_Internal_Void_GradientRemap_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060041FE RID: 16894 RVA: 0x0001C14F File Offset: 0x0001A34F
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170013C7 RID: 5063
			// (get) Token: 0x060041FF RID: 16895 RVA: 0x00103AF0 File Offset: 0x00101CF0
			// (set) Token: 0x06004200 RID: 16896 RVA: 0x0001C158 File Offset: 0x0001A358
			public unsafe static GradientRemapPool.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GradientRemapPool.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GradientRemapPool.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GradientRemapPool.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013C8 RID: 5064
			// (get) Token: 0x06004201 RID: 16897 RVA: 0x00103B18 File Offset: 0x00101D18
			// (set) Token: 0x06004202 RID: 16898 RVA: 0x0001C16A File Offset: 0x0001A36A
			public unsafe static Func<GradientRemap> __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GradientRemapPool.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<GradientRemap>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GradientRemapPool.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013C9 RID: 5065
			// (get) Token: 0x06004203 RID: 16899 RVA: 0x00103B40 File Offset: 0x00101D40
			// (set) Token: 0x06004204 RID: 16900 RVA: 0x0001C17C File Offset: 0x0001A37C
			public unsafe static Action<GradientRemap> __9__0_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GradientRemapPool.__c.NativeFieldInfoPtr___9__0_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<GradientRemap>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GradientRemapPool.__c.NativeFieldInfoPtr___9__0_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002E42 RID: 11842
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002E43 RID: 11843
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x04002E44 RID: 11844
			private static readonly IntPtr NativeFieldInfoPtr___9__0_1;

			// Token: 0x04002E45 RID: 11845
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002E46 RID: 11846
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__0_0_Internal_GradientRemap_0;

			// Token: 0x04002E47 RID: 11847
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__0_1_Internal_Void_GradientRemap_0;
		}

		// Token: 0x02000560 RID: 1376
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
