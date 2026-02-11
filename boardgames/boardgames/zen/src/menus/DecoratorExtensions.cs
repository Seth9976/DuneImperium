using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace zen.src.menus
{
	// Token: 0x02000053 RID: 83
	public static class DecoratorExtensions : Object
	{
		// Token: 0x0600045A RID: 1114 RVA: 0x0001DA44 File Offset: 0x0001BC44
		// Note: this type is marked as 'beforefieldinit'.
		static DecoratorExtensions()
		{
			Il2CppClassPointerStore<zen.src.menus.DecoratorExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "zen.src.menus", "DecoratorExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<zen.src.menus.DecoratorExtensions>.NativeClassPtr);
			zen.src.menus.DecoratorExtensions.NativeMethodInfoPtr_WithConnectivityIcon_Public_Static_Command_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.menus.DecoratorExtensions>.NativeClassPtr, 100663851);
			zen.src.menus.DecoratorExtensions.NativeMethodInfoPtr_WithDiskAccessIcon_Public_Static_Command_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.menus.DecoratorExtensions>.NativeClassPtr, 100663852);
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x0001DA9C File Offset: 0x0001BC9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985906, XrefRangeEnd = 985938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Command WithConnectivityIcon(this IEnumerator command)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.menus.DecoratorExtensions.NativeMethodInfoPtr_WithConnectivityIcon_Public_Static_Command_IEnumerator_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
			}
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0001DAE0 File Offset: 0x0001BCE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985938, XrefRangeEnd = 985951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Command WithDiskAccessIcon(this IEnumerator command)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(command);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.menus.DecoratorExtensions.NativeMethodInfoPtr_WithDiskAccessIcon_Public_Static_Command_IEnumerator_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Command>(intPtr3) : null;
			}
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00003FE7 File Offset: 0x000021E7
		public DecoratorExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400029F RID: 671
		private static readonly IntPtr NativeMethodInfoPtr_WithConnectivityIcon_Public_Static_Command_IEnumerator_0;

		// Token: 0x040002A0 RID: 672
		private static readonly IntPtr NativeMethodInfoPtr_WithDiskAccessIcon_Public_Static_Command_IEnumerator_0;

		// Token: 0x020001B9 RID: 441
		[ObfuscatedName("zen.src.menus.DecoratorExtensions+<>c__DisplayClass0_0")]
		public sealed class __c__DisplayClass0_0 : Object
		{
			// Token: 0x06001532 RID: 5426 RVA: 0x000525A8 File Offset: 0x000507A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<zen.src.menus.DecoratorExtensions.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<zen.src.menus.DecoratorExtensions>.NativeClassPtr, "<>c__DisplayClass0_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<zen.src.menus.DecoratorExtensions.__c__DisplayClass0_0>.NativeClassPtr);
				zen.src.menus.DecoratorExtensions.__c__DisplayClass0_0.NativeFieldInfoPtr_connectivityIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<zen.src.menus.DecoratorExtensions.__c__DisplayClass0_0>.NativeClassPtr, "connectivityIcon");
				zen.src.menus.DecoratorExtensions.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.menus.DecoratorExtensions.__c__DisplayClass0_0>.NativeClassPtr, 100663853);
				zen.src.menus.DecoratorExtensions.__c__DisplayClass0_0.NativeMethodInfoPtr__WithConnectivityIcon_b__0_Internal_Void_WithAnimationParameter_1_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<zen.src.menus.DecoratorExtensions.__c__DisplayClass0_0>.NativeClassPtr, 100663854);
			}

			// Token: 0x06001533 RID: 5427 RVA: 0x00052610 File Offset: 0x00050810
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<zen.src.menus.DecoratorExtensions.__c__DisplayClass0_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.menus.DecoratorExtensions.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001534 RID: 5428 RVA: 0x0005264C File Offset: 0x0005084C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 985904, XrefRangeEnd = 985906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _WithConnectivityIcon_b__0(WithAnimationParameter<IEnumerator> _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(_);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(zen.src.menus.DecoratorExtensions.__c__DisplayClass0_0.NativeMethodInfoPtr__WithConnectivityIcon_b__0_Internal_Void_WithAnimationParameter_1_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001535 RID: 5429 RVA: 0x0000BEF8 File Offset: 0x0000A0F8
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700060A RID: 1546
			// (get) Token: 0x06001536 RID: 5430 RVA: 0x00052690 File Offset: 0x00050890
			// (set) Token: 0x06001537 RID: 5431 RVA: 0x0000BF01 File Offset: 0x0000A101
			public unsafe ConnectivityIcon connectivityIcon
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.menus.DecoratorExtensions.__c__DisplayClass0_0.NativeFieldInfoPtr_connectivityIcon);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConnectivityIcon>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(zen.src.menus.DecoratorExtensions.__c__DisplayClass0_0.NativeFieldInfoPtr_connectivityIcon), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000CD6 RID: 3286
			private static readonly IntPtr NativeFieldInfoPtr_connectivityIcon;

			// Token: 0x04000CD7 RID: 3287
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000CD8 RID: 3288
			private static readonly IntPtr NativeMethodInfoPtr__WithConnectivityIcon_b__0_Internal_Void_WithAnimationParameter_1_IEnumerator_0;
		}
	}
}
