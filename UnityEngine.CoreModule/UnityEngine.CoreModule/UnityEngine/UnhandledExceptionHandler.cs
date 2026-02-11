using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000153 RID: 339
	public sealed class UnhandledExceptionHandler : Object
	{
		// Token: 0x06001951 RID: 6481 RVA: 0x00009DAC File Offset: 0x00007FAC
		// Note: this type is marked as 'beforefieldinit'.
		static UnhandledExceptionHandler()
		{
			Il2CppClassPointerStore<UnhandledExceptionHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "UnhandledExceptionHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnhandledExceptionHandler>.NativeClassPtr);
			UnhandledExceptionHandler.NativeMethodInfoPtr_RegisterUECatcher_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnhandledExceptionHandler>.NativeClassPtr, 100666788);
		}

		// Token: 0x06001952 RID: 6482 RVA: 0x00076BE4 File Offset: 0x00074DE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 667433, XrefRangeEnd = 667451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterUECatcher()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnhandledExceptionHandler.NativeMethodInfoPtr_RegisterUECatcher_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x00009DE5 File Offset: 0x00007FE5
		public UnhandledExceptionHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001688 RID: 5768
		private static readonly IntPtr NativeMethodInfoPtr_RegisterUECatcher_Private_Static_Void_0;

		// Token: 0x02000760 RID: 1888
		[ObfuscatedName("UnityEngine.UnhandledExceptionHandler+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003780 RID: 14208 RVA: 0x000BBE5C File Offset: 0x000BA05C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UnhandledExceptionHandler.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UnhandledExceptionHandler>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnhandledExceptionHandler.__c>.NativeClassPtr);
				UnhandledExceptionHandler.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnhandledExceptionHandler.__c>.NativeClassPtr, "<>9");
				UnhandledExceptionHandler.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnhandledExceptionHandler.__c>.NativeClassPtr, "<>9__0_0");
				UnhandledExceptionHandler.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnhandledExceptionHandler.__c>.NativeClassPtr, 100666790);
				UnhandledExceptionHandler.__c.NativeMethodInfoPtr__RegisterUECatcher_b__0_0_Internal_Void_Object_UnhandledExceptionEventArgs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnhandledExceptionHandler.__c>.NativeClassPtr, 100666791);
			}

			// Token: 0x06003781 RID: 14209 RVA: 0x000BBED8 File Offset: 0x000BA0D8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnhandledExceptionHandler.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnhandledExceptionHandler.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003782 RID: 14210 RVA: 0x000BBF14 File Offset: 0x000BA114
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 667424, XrefRangeEnd = 667433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RegisterUECatcher_b__0_0(Object sender, UnhandledExceptionEventArgs e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnhandledExceptionHandler.__c.NativeMethodInfoPtr__RegisterUECatcher_b__0_0_Internal_Void_Object_UnhandledExceptionEventArgs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003783 RID: 14211 RVA: 0x00013FE8 File Offset: 0x000121E8
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A27 RID: 2599
			// (get) Token: 0x06003784 RID: 14212 RVA: 0x000BBF68 File Offset: 0x000BA168
			// (set) Token: 0x06003785 RID: 14213 RVA: 0x00013FF1 File Offset: 0x000121F1
			public unsafe static UnhandledExceptionHandler.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UnhandledExceptionHandler.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnhandledExceptionHandler.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UnhandledExceptionHandler.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A28 RID: 2600
			// (get) Token: 0x06003786 RID: 14214 RVA: 0x000BBF90 File Offset: 0x000BA190
			// (set) Token: 0x06003787 RID: 14215 RVA: 0x00014003 File Offset: 0x00012203
			public unsafe static UnhandledExceptionEventHandler __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UnhandledExceptionHandler.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnhandledExceptionEventHandler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UnhandledExceptionHandler.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002C78 RID: 11384
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002C79 RID: 11385
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x04002C7A RID: 11386
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002C7B RID: 11387
			private static readonly IntPtr NativeMethodInfoPtr__RegisterUECatcher_b__0_0_Internal_Void_Object_UnhandledExceptionEventArgs_0;
		}

		// Token: 0x02000761 RID: 1889
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
