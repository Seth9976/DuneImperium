using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Globalization;

namespace UnityEngine.UIElements
{
	// Token: 0x020001FD RID: 509
	public class UxmlLongAttributeDescription : TypedUxmlAttributeDescription<long>
	{
		// Token: 0x060027C6 RID: 10182 RVA: 0x000AF0F4 File Offset: 0x000AD2F4
		// Note: this type is marked as 'beforefieldinit'.
		static UxmlLongAttributeDescription()
		{
			Il2CppClassPointerStore<UxmlLongAttributeDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UxmlLongAttributeDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlLongAttributeDescription>.NativeClassPtr);
			UxmlLongAttributeDescription.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlLongAttributeDescription>.NativeClassPtr, 100669283);
			UxmlLongAttributeDescription.NativeMethodInfoPtr_GetValueFromBag_Public_Virtual_Int64_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlLongAttributeDescription>.NativeClassPtr, 100669284);
			UxmlLongAttributeDescription.NativeMethodInfoPtr_ConvertValueToLong_Private_Static_Int64_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlLongAttributeDescription>.NativeClassPtr, 100669285);
		}

		// Token: 0x060027C7 RID: 10183 RVA: 0x000AF160 File Offset: 0x000AD360
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 343625, RefRangeEnd = 343628, XrefRangeStart = 343615, XrefRangeEnd = 343625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UxmlLongAttributeDescription()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UxmlLongAttributeDescription>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlLongAttributeDescription.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027C8 RID: 10184 RVA: 0x000AF19C File Offset: 0x000AD39C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343628, XrefRangeEnd = 343647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override long GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bag);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cc));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UxmlLongAttributeDescription.NativeMethodInfoPtr_GetValueFromBag_Public_Virtual_Int64_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027C9 RID: 10185 RVA: 0x000AF20C File Offset: 0x000AD40C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343647, XrefRangeEnd = 343648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static long ConvertValueToLong(string v, long defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(v);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlLongAttributeDescription.NativeMethodInfoPtr_ConvertValueToLong_Private_Static_Int64_String_Int64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027CA RID: 10186 RVA: 0x00010203 File Offset: 0x0000E403
		public UxmlLongAttributeDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x060027CB RID: 10187 RVA: 0x000AF25C File Offset: 0x000AD45C
		public override string defaultValueAsString
		{
			get
			{
				return base.defaultValue.ToString(CultureInfo.InvariantCulture.NumberFormat);
			}
		}

		// Token: 0x060027CC RID: 10188 RVA: 0x0001020C File Offset: 0x0000E40C
		public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref long value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04001C42 RID: 7234
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001C43 RID: 7235
		private static readonly IntPtr NativeMethodInfoPtr_GetValueFromBag_Public_Virtual_Int64_IUxmlAttributes_CreationContext_0;

		// Token: 0x04001C44 RID: 7236
		private static readonly IntPtr NativeMethodInfoPtr_ConvertValueToLong_Private_Static_Int64_String_Int64_0;

		// Token: 0x0200050F RID: 1295
		[ObfuscatedName("UnityEngine.UIElements.UxmlLongAttributeDescription+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003FDE RID: 16350 RVA: 0x000FE214 File Offset: 0x000FC414
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UxmlLongAttributeDescription.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UxmlLongAttributeDescription>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlLongAttributeDescription.__c>.NativeClassPtr);
				UxmlLongAttributeDescription.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlLongAttributeDescription.__c>.NativeClassPtr, "<>9");
				UxmlLongAttributeDescription.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlLongAttributeDescription.__c>.NativeClassPtr, "<>9__3_0");
				UxmlLongAttributeDescription.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlLongAttributeDescription.__c>.NativeClassPtr, 100669287);
				UxmlLongAttributeDescription.__c.NativeMethodInfoPtr__GetValueFromBag_b__3_0_Internal_Int64_String_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlLongAttributeDescription.__c>.NativeClassPtr, 100669288);
			}

			// Token: 0x06003FDF RID: 16351 RVA: 0x000FE290 File Offset: 0x000FC490
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UxmlLongAttributeDescription.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlLongAttributeDescription.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003FE0 RID: 16352 RVA: 0x000FE2CC File Offset: 0x000FC4CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343614, XrefRangeEnd = 343615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe long _GetValueFromBag_b__3_0(string s, long l)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref l;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlLongAttributeDescription.__c.NativeMethodInfoPtr__GetValueFromBag_b__3_0_Internal_Int64_String_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003FE1 RID: 16353 RVA: 0x0001AC69 File Offset: 0x00018E69
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001320 RID: 4896
			// (get) Token: 0x06003FE2 RID: 16354 RVA: 0x000FE328 File Offset: 0x000FC528
			// (set) Token: 0x06003FE3 RID: 16355 RVA: 0x0001AC72 File Offset: 0x00018E72
			public unsafe static UxmlLongAttributeDescription.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UxmlLongAttributeDescription.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlLongAttributeDescription.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UxmlLongAttributeDescription.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001321 RID: 4897
			// (get) Token: 0x06003FE4 RID: 16356 RVA: 0x000FE350 File Offset: 0x000FC550
			// (set) Token: 0x06003FE5 RID: 16357 RVA: 0x0001AC84 File Offset: 0x00018E84
			public unsafe static Func<string, long, long> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UxmlLongAttributeDescription.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, long, long>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UxmlLongAttributeDescription.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D13 RID: 11539
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002D14 RID: 11540
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04002D15 RID: 11541
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D16 RID: 11542
			private static readonly IntPtr NativeMethodInfoPtr__GetValueFromBag_b__3_0_Internal_Int64_String_Int64_0;
		}

		// Token: 0x02000510 RID: 1296
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
