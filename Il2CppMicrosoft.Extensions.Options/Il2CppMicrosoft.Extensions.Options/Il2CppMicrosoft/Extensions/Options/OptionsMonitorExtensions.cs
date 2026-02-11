using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppMicrosoft.Extensions.Options
{
	// Token: 0x0200001D RID: 29
	public static class OptionsMonitorExtensions : Object
	{
		// Token: 0x0600008D RID: 141 RVA: 0x00002430 File Offset: 0x00000630
		// Note: this type is marked as 'beforefieldinit'.
		static OptionsMonitorExtensions()
		{
			Il2CppClassPointerStore<OptionsMonitorExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.Options.dll", "Microsoft.Extensions.Options", "OptionsMonitorExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsMonitorExtensions>.NativeClassPtr);
			OptionsMonitorExtensions.NativeMethodInfoPtr_OnChange_Public_Static_IDisposable_IOptionsMonitor_1_TOptions_Action_1_TOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsMonitorExtensions>.NativeClassPtr, 100663366);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000048C0 File Offset: 0x00002AC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1266021, RefRangeEnd = 1266022, XrefRangeStart = 1266009, XrefRangeEnd = 1266021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IDisposable OnChange<TOptions>(this IOptionsMonitor<TOptions> monitor, Action<TOptions> listener)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(monitor);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listener);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionsMonitorExtensions.MethodInfoStoreGeneric_OnChange_Public_Static_IDisposable_IOptionsMonitor_1_TOptions_Action_1_TOptions_0<TOptions>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDisposable>(intPtr3) : null;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002469 File Offset: 0x00000669
		public OptionsMonitorExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_OnChange_Public_Static_IDisposable_IOptionsMonitor_1_TOptions_Action_1_TOptions_0;

		// Token: 0x0200002A RID: 42
		[ObfuscatedName("Microsoft.Extensions.Options.OptionsMonitorExtensions+<>c__DisplayClass0_0`1")]
		public sealed class __c__DisplayClass0_0<TOptions> : Object
		{
			// Token: 0x060000FC RID: 252 RVA: 0x00005FC8 File Offset: 0x000041C8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass0_0()
			{
				Il2CppClassPointerStore<OptionsMonitorExtensions.__c__DisplayClass0_0<TOptions>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<OptionsMonitorExtensions>.NativeClassPtr, "<>c__DisplayClass0_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOptions>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptionsMonitorExtensions.__c__DisplayClass0_0<TOptions>>.NativeClassPtr);
				OptionsMonitorExtensions.__c__DisplayClass0_0<TOptions>.NativeFieldInfoPtr_listener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptionsMonitorExtensions.__c__DisplayClass0_0<TOptions>>.NativeClassPtr, "listener");
				OptionsMonitorExtensions.__c__DisplayClass0_0<TOptions>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsMonitorExtensions.__c__DisplayClass0_0<TOptions>>.NativeClassPtr, 100663367);
				OptionsMonitorExtensions.__c__DisplayClass0_0<TOptions>.NativeMethodInfoPtr__OnChange_b__0_Internal_Void_TOptions_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptionsMonitorExtensions.__c__DisplayClass0_0<TOptions>>.NativeClassPtr, 100663368);
			}

			// Token: 0x060000FD RID: 253 RVA: 0x0000606C File Offset: 0x0000426C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass0_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptionsMonitorExtensions.__c__DisplayClass0_0<TOptions>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptionsMonitorExtensions.__c__DisplayClass0_0<TOptions>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060000FE RID: 254 RVA: 0x000060A8 File Offset: 0x000042A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1266006, XrefRangeEnd = 1266009, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _OnChange_b__0(TOptions o, string _)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(TOptions).IsValueType)
					{
						TOptions toptions = o;
						intPtr = ((toptions is string) ? IL2CPP.ManagedStringToIl2Cpp(toptions as string) : IL2CPP.Il2CppObjectBaseToPtr(toptions as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref o;
					}
					ptr2 = intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_);
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(OptionsMonitorExtensions.__c__DisplayClass0_0<TOptions>.NativeMethodInfoPtr__OnChange_b__0_Internal_Void_TOptions_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}

			// Token: 0x060000FF RID: 255 RVA: 0x000027B5 File Offset: 0x000009B5
			public __c__DisplayClass0_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700003F RID: 63
			// (get) Token: 0x06000100 RID: 256 RVA: 0x00006134 File Offset: 0x00004334
			// (set) Token: 0x06000101 RID: 257 RVA: 0x000027BE File Offset: 0x000009BE
			public unsafe Action<TOptions> listener
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsMonitorExtensions.__c__DisplayClass0_0<TOptions>.NativeFieldInfoPtr_listener);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<TOptions>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptionsMonitorExtensions.__c__DisplayClass0_0<TOptions>.NativeFieldInfoPtr_listener), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000090 RID: 144
			private static readonly IntPtr NativeFieldInfoPtr_listener;

			// Token: 0x04000091 RID: 145
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000092 RID: 146
			private static readonly IntPtr NativeMethodInfoPtr__OnChange_b__0_Internal_Void_TOptions_String_0;
		}

		// Token: 0x0200002B RID: 43
		private sealed class MethodInfoStoreGeneric_OnChange_Public_Static_IDisposable_IOptionsMonitor_1_TOptions_Action_1_TOptions_0<TOptions>
		{
			// Token: 0x04000093 RID: 147
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(OptionsMonitorExtensions.NativeMethodInfoPtr_OnChange_Public_Static_IDisposable_IOptionsMonitor_1_TOptions_Action_1_TOptions_0, Il2CppClassPointerStore<OptionsMonitorExtensions>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TOptions>.NativeClassPtr)) }))));
		}
	}
}
