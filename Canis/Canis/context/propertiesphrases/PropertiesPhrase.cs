using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Canis.context.propertiesphrases
{
	// Token: 0x0200014A RID: 330
	[Serializable]
	public class PropertiesPhrase : Object
	{
		// Token: 0x06000E9F RID: 3743 RVA: 0x00057168 File Offset: 0x00055368
		// Note: this type is marked as 'beforefieldinit'.
		static PropertiesPhrase()
		{
			Il2CppClassPointerStore<PropertiesPhrase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.propertiesphrases", "PropertiesPhrase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertiesPhrase>.NativeClassPtr);
			PropertiesPhrase.NativeMethodInfoPtr_Evaluate_Public_Abstract_Virtual_New_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertiesPhrase>.NativeClassPtr, 100666442);
			PropertiesPhrase.NativeMethodInfoPtr_op_Implicit_Public_Static_Func_2_Context_Boolean_PropertiesPhrase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertiesPhrase>.NativeClassPtr, 100666443);
			PropertiesPhrase.NativeMethodInfoPtr_op_Implicit_Public_Static_PropertiesPhrase_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertiesPhrase>.NativeClassPtr, 100666444);
			PropertiesPhrase.NativeMethodInfoPtr_op_LogicalNot_Public_Static_PropertiesPhrase_PropertiesPhrase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertiesPhrase>.NativeClassPtr, 100666445);
			PropertiesPhrase.NativeMethodInfoPtr_And_Public_PropertiesPhrase_PropertiesPhrase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertiesPhrase>.NativeClassPtr, 100666446);
			PropertiesPhrase.NativeMethodInfoPtr_Or_Public_PropertiesPhrase_PropertiesPhrase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertiesPhrase>.NativeClassPtr, 100666447);
			PropertiesPhrase.NativeMethodInfoPtr_If_Public_Func_2_Context_T_PropertiesPhrase_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertiesPhrase>.NativeClassPtr, 100666448);
			PropertiesPhrase.NativeMethodInfoPtr_ContextualIf_Public_Func_2_Context_T_PropertiesPhrase_Func_2_Context_T_Func_2_Context_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertiesPhrase>.NativeClassPtr, 100666449);
			PropertiesPhrase.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertiesPhrase>.NativeClassPtr, 100666450);
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x0005724C File Offset: 0x0005544C
		[CallerCount(0)]
		public unsafe virtual bool Evaluate(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertiesPhrase.NativeMethodInfoPtr_Evaluate_Public_Abstract_Virtual_New_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x000572A4 File Offset: 0x000554A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577454, XrefRangeEnd = 577458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Func<Context, bool>(PropertiesPhrase phrase)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(phrase);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertiesPhrase.NativeMethodInfoPtr_op_Implicit_Public_Static_Func_2_Context_Boolean_PropertiesPhrase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Context, bool>>(intPtr3) : null;
			}
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x000572E8 File Offset: 0x000554E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577458, XrefRangeEnd = 577463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator PropertiesPhrase(bool booleanVal)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref booleanVal;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertiesPhrase.NativeMethodInfoPtr_op_Implicit_Public_Static_PropertiesPhrase_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertiesPhrase>(intPtr3) : null;
			}
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x00057328 File Offset: 0x00055528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577463, XrefRangeEnd = 577466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertiesPhrase operator !(PropertiesPhrase phrase)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(phrase);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertiesPhrase.NativeMethodInfoPtr_op_LogicalNot_Public_Static_PropertiesPhrase_PropertiesPhrase_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertiesPhrase>(intPtr3) : null;
			}
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x0005736C File Offset: 0x0005556C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577466, XrefRangeEnd = 577472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertiesPhrase And(PropertiesPhrase other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertiesPhrase.NativeMethodInfoPtr_And_Public_PropertiesPhrase_PropertiesPhrase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertiesPhrase>(intPtr3) : null;
			}
		}

		// Token: 0x06000EA5 RID: 3749 RVA: 0x000573BC File Offset: 0x000555BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577472, XrefRangeEnd = 577478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertiesPhrase Or(PropertiesPhrase other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertiesPhrase.NativeMethodInfoPtr_Or_Public_PropertiesPhrase_PropertiesPhrase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertiesPhrase>(intPtr3) : null;
			}
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x0005740C File Offset: 0x0005560C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577478, XrefRangeEnd = 577492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Func<Context, T> If<T>(PropertiesPhrase phrase, T ifTrue, T ifFalse)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(phrase);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = ifTrue;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref ifTrue;
			}
			ptr2 = intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T).IsValueType)
			{
				T t2 = ifFalse;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref ifFalse;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(PropertiesPhrase.MethodInfoStoreGeneric_If_Public_Func_2_Context_T_PropertiesPhrase_T_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr3;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Func<Context, T>>(intPtr5) : null;
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x000574EC File Offset: 0x000556EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577492, XrefRangeEnd = 577500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Func<Context, T> ContextualIf<T>(PropertiesPhrase phrase, Func<Context, T> ifTrue, Func<Context, T> ifFalse)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(phrase);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ifTrue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ifFalse);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertiesPhrase.MethodInfoStoreGeneric_ContextualIf_Public_Func_2_Context_T_PropertiesPhrase_Func_2_Context_T_Func_2_Context_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Context, T>>(intPtr3) : null;
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x00057560 File Offset: 0x00055760
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertiesPhrase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertiesPhrase>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertiesPhrase.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x000075F6 File Offset: 0x000057F6
		public PropertiesPhrase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009D8 RID: 2520
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Abstract_Virtual_New_Boolean_Context_0;

		// Token: 0x040009D9 RID: 2521
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Func_2_Context_Boolean_PropertiesPhrase_0;

		// Token: 0x040009DA RID: 2522
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_PropertiesPhrase_Boolean_0;

		// Token: 0x040009DB RID: 2523
		private static readonly IntPtr NativeMethodInfoPtr_op_LogicalNot_Public_Static_PropertiesPhrase_PropertiesPhrase_0;

		// Token: 0x040009DC RID: 2524
		private static readonly IntPtr NativeMethodInfoPtr_And_Public_PropertiesPhrase_PropertiesPhrase_0;

		// Token: 0x040009DD RID: 2525
		private static readonly IntPtr NativeMethodInfoPtr_Or_Public_PropertiesPhrase_PropertiesPhrase_0;

		// Token: 0x040009DE RID: 2526
		private static readonly IntPtr NativeMethodInfoPtr_If_Public_Func_2_Context_T_PropertiesPhrase_T_T_0;

		// Token: 0x040009DF RID: 2527
		private static readonly IntPtr NativeMethodInfoPtr_ContextualIf_Public_Func_2_Context_T_PropertiesPhrase_Func_2_Context_T_Func_2_Context_T_0;

		// Token: 0x040009E0 RID: 2528
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000391 RID: 913
		[ObfuscatedName("Canis.context.propertiesphrases.PropertiesPhrase+<>c__DisplayClass6_0`1")]
		public sealed class __c__DisplayClass6_0<T> : Object
		{
			// Token: 0x060025FF RID: 9727 RVA: 0x000A7C44 File Offset: 0x000A5E44
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass6_0()
			{
				Il2CppClassPointerStore<PropertiesPhrase.__c__DisplayClass6_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertiesPhrase>.NativeClassPtr, "<>c__DisplayClass6_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertiesPhrase.__c__DisplayClass6_0<T>>.NativeClassPtr);
				PropertiesPhrase.__c__DisplayClass6_0<T>.NativeFieldInfoPtr_phrase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertiesPhrase.__c__DisplayClass6_0<T>>.NativeClassPtr, "phrase");
				PropertiesPhrase.__c__DisplayClass6_0<T>.NativeFieldInfoPtr_ifTrue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertiesPhrase.__c__DisplayClass6_0<T>>.NativeClassPtr, "ifTrue");
				PropertiesPhrase.__c__DisplayClass6_0<T>.NativeFieldInfoPtr_ifFalse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertiesPhrase.__c__DisplayClass6_0<T>>.NativeClassPtr, "ifFalse");
				PropertiesPhrase.__c__DisplayClass6_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertiesPhrase.__c__DisplayClass6_0<T>>.NativeClassPtr, 100666451);
				PropertiesPhrase.__c__DisplayClass6_0<T>.NativeMethodInfoPtr__If_b__0_Internal_T_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertiesPhrase.__c__DisplayClass6_0<T>>.NativeClassPtr, 100666452);
			}

			// Token: 0x06002600 RID: 9728 RVA: 0x000A7D10 File Offset: 0x000A5F10
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass6_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertiesPhrase.__c__DisplayClass6_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertiesPhrase.__c__DisplayClass6_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002601 RID: 9729 RVA: 0x000A7D4C File Offset: 0x000A5F4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577446, XrefRangeEnd = 577452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T _If_b__0(Context context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertiesPhrase.__c__DisplayClass6_0<T>.NativeMethodInfoPtr__If_b__0_Internal_T_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x06002602 RID: 9730 RVA: 0x000121EB File Offset: 0x000103EB
			public __c__DisplayClass6_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000957 RID: 2391
			// (get) Token: 0x06002603 RID: 9731 RVA: 0x000A7D98 File Offset: 0x000A5F98
			// (set) Token: 0x06002604 RID: 9732 RVA: 0x000121F4 File Offset: 0x000103F4
			public unsafe PropertiesPhrase phrase
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertiesPhrase.__c__DisplayClass6_0<T>.NativeFieldInfoPtr_phrase);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertiesPhrase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertiesPhrase.__c__DisplayClass6_0<T>.NativeFieldInfoPtr_phrase), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000958 RID: 2392
			// (get) Token: 0x06002605 RID: 9733 RVA: 0x000A7DC8 File Offset: 0x000A5FC8
			// (set) Token: 0x06002606 RID: 9734 RVA: 0x000A7DF0 File Offset: 0x000A5FF0
			public unsafe T ifTrue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertiesPhrase.__c__DisplayClass6_0<T>.NativeFieldInfoPtr_ifTrue);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertiesPhrase.__c__DisplayClass6_0<T>.NativeFieldInfoPtr_ifTrue);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x17000959 RID: 2393
			// (get) Token: 0x06002607 RID: 9735 RVA: 0x000A7E98 File Offset: 0x000A6098
			// (set) Token: 0x06002608 RID: 9736 RVA: 0x000A7EC0 File Offset: 0x000A60C0
			public unsafe T ifFalse
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertiesPhrase.__c__DisplayClass6_0<T>.NativeFieldInfoPtr_ifFalse);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertiesPhrase.__c__DisplayClass6_0<T>.NativeFieldInfoPtr_ifFalse);
					Type typeFromHandle = typeof(T);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x040017B9 RID: 6073
			private static readonly IntPtr NativeFieldInfoPtr_phrase;

			// Token: 0x040017BA RID: 6074
			private static readonly IntPtr NativeFieldInfoPtr_ifTrue;

			// Token: 0x040017BB RID: 6075
			private static readonly IntPtr NativeFieldInfoPtr_ifFalse;

			// Token: 0x040017BC RID: 6076
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040017BD RID: 6077
			private static readonly IntPtr NativeMethodInfoPtr__If_b__0_Internal_T_Context_0;
		}

		// Token: 0x02000392 RID: 914
		[ObfuscatedName("Canis.context.propertiesphrases.PropertiesPhrase+<>c__DisplayClass7_0`1")]
		public sealed class __c__DisplayClass7_0<T> : Object
		{
			// Token: 0x06002609 RID: 9737 RVA: 0x000A7F68 File Offset: 0x000A6168
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<PropertiesPhrase.__c__DisplayClass7_0<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PropertiesPhrase>.NativeClassPtr, "<>c__DisplayClass7_0`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertiesPhrase.__c__DisplayClass7_0<T>>.NativeClassPtr);
				PropertiesPhrase.__c__DisplayClass7_0<T>.NativeFieldInfoPtr_phrase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertiesPhrase.__c__DisplayClass7_0<T>>.NativeClassPtr, "phrase");
				PropertiesPhrase.__c__DisplayClass7_0<T>.NativeFieldInfoPtr_ifTrue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertiesPhrase.__c__DisplayClass7_0<T>>.NativeClassPtr, "ifTrue");
				PropertiesPhrase.__c__DisplayClass7_0<T>.NativeFieldInfoPtr_ifFalse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertiesPhrase.__c__DisplayClass7_0<T>>.NativeClassPtr, "ifFalse");
				PropertiesPhrase.__c__DisplayClass7_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertiesPhrase.__c__DisplayClass7_0<T>>.NativeClassPtr, 100666453);
				PropertiesPhrase.__c__DisplayClass7_0<T>.NativeMethodInfoPtr__ContextualIf_b__0_Internal_T_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertiesPhrase.__c__DisplayClass7_0<T>>.NativeClassPtr, 100666454);
			}

			// Token: 0x0600260A RID: 9738 RVA: 0x000A8034 File Offset: 0x000A6234
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertiesPhrase.__c__DisplayClass7_0<T>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertiesPhrase.__c__DisplayClass7_0<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600260B RID: 9739 RVA: 0x000A8070 File Offset: 0x000A6270
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577452, XrefRangeEnd = 577454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe T _ContextualIf_b__0(Context context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertiesPhrase.__c__DisplayClass7_0<T>.NativeMethodInfoPtr__ContextualIf_b__0_Internal_T_Context_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
				}
			}

			// Token: 0x0600260C RID: 9740 RVA: 0x00012213 File Offset: 0x00010413
			public __c__DisplayClass7_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700095A RID: 2394
			// (get) Token: 0x0600260D RID: 9741 RVA: 0x000A80BC File Offset: 0x000A62BC
			// (set) Token: 0x0600260E RID: 9742 RVA: 0x0001221C File Offset: 0x0001041C
			public unsafe PropertiesPhrase phrase
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertiesPhrase.__c__DisplayClass7_0<T>.NativeFieldInfoPtr_phrase);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertiesPhrase>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertiesPhrase.__c__DisplayClass7_0<T>.NativeFieldInfoPtr_phrase), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700095B RID: 2395
			// (get) Token: 0x0600260F RID: 9743 RVA: 0x000A80EC File Offset: 0x000A62EC
			// (set) Token: 0x06002610 RID: 9744 RVA: 0x0001223B File Offset: 0x0001043B
			public unsafe Func<Context, T> ifTrue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertiesPhrase.__c__DisplayClass7_0<T>.NativeFieldInfoPtr_ifTrue);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Context, T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertiesPhrase.__c__DisplayClass7_0<T>.NativeFieldInfoPtr_ifTrue), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700095C RID: 2396
			// (get) Token: 0x06002611 RID: 9745 RVA: 0x000A811C File Offset: 0x000A631C
			// (set) Token: 0x06002612 RID: 9746 RVA: 0x0001225A File Offset: 0x0001045A
			public unsafe Func<Context, T> ifFalse
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertiesPhrase.__c__DisplayClass7_0<T>.NativeFieldInfoPtr_ifFalse);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Context, T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertiesPhrase.__c__DisplayClass7_0<T>.NativeFieldInfoPtr_ifFalse), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040017BE RID: 6078
			private static readonly IntPtr NativeFieldInfoPtr_phrase;

			// Token: 0x040017BF RID: 6079
			private static readonly IntPtr NativeFieldInfoPtr_ifTrue;

			// Token: 0x040017C0 RID: 6080
			private static readonly IntPtr NativeFieldInfoPtr_ifFalse;

			// Token: 0x040017C1 RID: 6081
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040017C2 RID: 6082
			private static readonly IntPtr NativeMethodInfoPtr__ContextualIf_b__0_Internal_T_Context_0;
		}

		// Token: 0x02000393 RID: 915
		private sealed class MethodInfoStoreGeneric_If_Public_Func_2_Context_T_PropertiesPhrase_T_T_0<T>
		{
			// Token: 0x040017C3 RID: 6083
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PropertiesPhrase.NativeMethodInfoPtr_If_Public_Func_2_Context_T_PropertiesPhrase_T_T_0, Il2CppClassPointerStore<PropertiesPhrase>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000394 RID: 916
		private sealed class MethodInfoStoreGeneric_ContextualIf_Public_Func_2_Context_T_PropertiesPhrase_Func_2_Context_T_Func_2_Context_T_0<T>
		{
			// Token: 0x040017C4 RID: 6084
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PropertiesPhrase.NativeMethodInfoPtr_ContextualIf_Public_Func_2_Context_T_PropertiesPhrase_Func_2_Context_T_Func_2_Context_T_0, Il2CppClassPointerStore<PropertiesPhrase>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
