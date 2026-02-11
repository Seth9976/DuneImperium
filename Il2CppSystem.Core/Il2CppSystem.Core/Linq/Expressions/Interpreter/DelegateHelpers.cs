using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x02000105 RID: 261
	public static class DelegateHelpers : Object
	{
		// Token: 0x06000FC7 RID: 4039 RVA: 0x00006E95 File Offset: 0x00005095
		// Note: this type is marked as 'beforefieldinit'.
		static DelegateHelpers()
		{
			Il2CppClassPointerStore<DelegateHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "DelegateHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelegateHelpers>.NativeClassPtr);
			DelegateHelpers.NativeMethodInfoPtr_MakeDelegate_Internal_Static_Type_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateHelpers>.NativeClassPtr, 100666233);
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x00053240 File Offset: 0x00051440
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1026907, RefRangeEnd = 1026908, XrefRangeStart = 1026807, XrefRangeEnd = 1026907, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type MakeDelegate(Il2CppReferenceArray<Type> types)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(types);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateHelpers.NativeMethodInfoPtr_MakeDelegate_Internal_Static_Type_Il2CppReferenceArray_1_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x00006ECE File Offset: 0x000050CE
		public DelegateHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B57 RID: 2903
		private static readonly IntPtr NativeMethodInfoPtr_MakeDelegate_Internal_Static_Type_Il2CppReferenceArray_1_Type_0;

		// Token: 0x0200032B RID: 811
		[ObfuscatedName("System.Linq.Expressions.Interpreter.DelegateHelpers+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001B2D RID: 6957 RVA: 0x0008148C File Offset: 0x0007F68C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DelegateHelpers.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DelegateHelpers>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DelegateHelpers.__c>.NativeClassPtr);
				DelegateHelpers.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateHelpers.__c>.NativeClassPtr, "<>9");
				DelegateHelpers.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DelegateHelpers.__c>.NativeClassPtr, "<>9__1_0");
				DelegateHelpers.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateHelpers.__c>.NativeClassPtr, 100666235);
				DelegateHelpers.__c.NativeMethodInfoPtr__MakeDelegate_b__1_0_Internal_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DelegateHelpers.__c>.NativeClassPtr, 100666236);
			}

			// Token: 0x06001B2E RID: 6958 RVA: 0x00081508 File Offset: 0x0007F708
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DelegateHelpers.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateHelpers.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B2F RID: 6959 RVA: 0x00081544 File Offset: 0x0007F744
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026805, XrefRangeEnd = 1026807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _MakeDelegate_b__1_0(Type t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DelegateHelpers.__c.NativeMethodInfoPtr__MakeDelegate_b__1_0_Internal_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06001B30 RID: 6960 RVA: 0x0000A5A2 File Offset: 0x000087A2
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006DA RID: 1754
			// (get) Token: 0x06001B31 RID: 6961 RVA: 0x00081594 File Offset: 0x0007F794
			// (set) Token: 0x06001B32 RID: 6962 RVA: 0x0000A5AB File Offset: 0x000087AB
			public unsafe static DelegateHelpers.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DelegateHelpers.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DelegateHelpers.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DelegateHelpers.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006DB RID: 1755
			// (get) Token: 0x06001B33 RID: 6963 RVA: 0x000815BC File Offset: 0x0007F7BC
			// (set) Token: 0x06001B34 RID: 6964 RVA: 0x0000A5BD File Offset: 0x000087BD
			public unsafe static Func<Type, bool> __9__1_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DelegateHelpers.__c.NativeFieldInfoPtr___9__1_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Type, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DelegateHelpers.__c.NativeFieldInfoPtr___9__1_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001261 RID: 4705
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001262 RID: 4706
			private static readonly IntPtr NativeFieldInfoPtr___9__1_0;

			// Token: 0x04001263 RID: 4707
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001264 RID: 4708
			private static readonly IntPtr NativeMethodInfoPtr__MakeDelegate_b__1_0_Internal_Boolean_Type_0;
		}
	}
}
