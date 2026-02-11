using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Globalization;

namespace UnityEngine.UIElements
{
	// Token: 0x020001FC RID: 508
	public class UxmlUnsignedLongAttributeDescription : TypedUxmlAttributeDescription<ulong>
	{
		// Token: 0x060027BF RID: 10175 RVA: 0x000AEF60 File Offset: 0x000AD160
		// Note: this type is marked as 'beforefieldinit'.
		static UxmlUnsignedLongAttributeDescription()
		{
			Il2CppClassPointerStore<UxmlUnsignedLongAttributeDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UxmlUnsignedLongAttributeDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlUnsignedLongAttributeDescription>.NativeClassPtr);
			UxmlUnsignedLongAttributeDescription.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlUnsignedLongAttributeDescription>.NativeClassPtr, 100669277);
			UxmlUnsignedLongAttributeDescription.NativeMethodInfoPtr_GetValueFromBag_Public_Virtual_UInt64_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlUnsignedLongAttributeDescription>.NativeClassPtr, 100669278);
			UxmlUnsignedLongAttributeDescription.NativeMethodInfoPtr_ConvertValueToUlong_Private_Static_UInt64_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlUnsignedLongAttributeDescription>.NativeClassPtr, 100669279);
		}

		// Token: 0x060027C0 RID: 10176 RVA: 0x000AEFCC File Offset: 0x000AD1CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343584, XrefRangeEnd = 343594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UxmlUnsignedLongAttributeDescription()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UxmlUnsignedLongAttributeDescription>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlUnsignedLongAttributeDescription.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027C1 RID: 10177 RVA: 0x000AF008 File Offset: 0x000AD208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343594, XrefRangeEnd = 343613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ulong GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UxmlUnsignedLongAttributeDescription.NativeMethodInfoPtr_GetValueFromBag_Public_Virtual_UInt64_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027C2 RID: 10178 RVA: 0x000AF078 File Offset: 0x000AD278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343613, XrefRangeEnd = 343614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong ConvertValueToUlong(string v, ulong defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(v);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlUnsignedLongAttributeDescription.NativeMethodInfoPtr_ConvertValueToUlong_Private_Static_UInt64_String_UInt64_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027C3 RID: 10179 RVA: 0x000101ED File Offset: 0x0000E3ED
		public UxmlUnsignedLongAttributeDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x060027C4 RID: 10180 RVA: 0x000AF0C8 File Offset: 0x000AD2C8
		public override string defaultValueAsString
		{
			get
			{
				return base.defaultValue.ToString(CultureInfo.InvariantCulture.NumberFormat);
			}
		}

		// Token: 0x060027C5 RID: 10181 RVA: 0x000101F6 File Offset: 0x0000E3F6
		public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref ulong value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04001C3F RID: 7231
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001C40 RID: 7232
		private static readonly IntPtr NativeMethodInfoPtr_GetValueFromBag_Public_Virtual_UInt64_IUxmlAttributes_CreationContext_0;

		// Token: 0x04001C41 RID: 7233
		private static readonly IntPtr NativeMethodInfoPtr_ConvertValueToUlong_Private_Static_UInt64_String_UInt64_0;

		// Token: 0x0200050D RID: 1293
		[ObfuscatedName("UnityEngine.UIElements.UxmlUnsignedLongAttributeDescription+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003FD6 RID: 16342 RVA: 0x000FE0B0 File Offset: 0x000FC2B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UxmlUnsignedLongAttributeDescription.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UxmlUnsignedLongAttributeDescription>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlUnsignedLongAttributeDescription.__c>.NativeClassPtr);
				UxmlUnsignedLongAttributeDescription.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlUnsignedLongAttributeDescription.__c>.NativeClassPtr, "<>9");
				UxmlUnsignedLongAttributeDescription.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlUnsignedLongAttributeDescription.__c>.NativeClassPtr, "<>9__3_0");
				UxmlUnsignedLongAttributeDescription.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlUnsignedLongAttributeDescription.__c>.NativeClassPtr, 100669281);
				UxmlUnsignedLongAttributeDescription.__c.NativeMethodInfoPtr__GetValueFromBag_b__3_0_Internal_UInt64_String_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlUnsignedLongAttributeDescription.__c>.NativeClassPtr, 100669282);
			}

			// Token: 0x06003FD7 RID: 16343 RVA: 0x000FE12C File Offset: 0x000FC32C
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UxmlUnsignedLongAttributeDescription.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlUnsignedLongAttributeDescription.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003FD8 RID: 16344 RVA: 0x000FE168 File Offset: 0x000FC368
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343583, XrefRangeEnd = 343584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ulong _GetValueFromBag_b__3_0(string s, ulong l)
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlUnsignedLongAttributeDescription.__c.NativeMethodInfoPtr__GetValueFromBag_b__3_0_Internal_UInt64_String_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003FD9 RID: 16345 RVA: 0x0001AC3C File Offset: 0x00018E3C
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700131E RID: 4894
			// (get) Token: 0x06003FDA RID: 16346 RVA: 0x000FE1C4 File Offset: 0x000FC3C4
			// (set) Token: 0x06003FDB RID: 16347 RVA: 0x0001AC45 File Offset: 0x00018E45
			public unsafe static UxmlUnsignedLongAttributeDescription.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UxmlUnsignedLongAttributeDescription.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlUnsignedLongAttributeDescription.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UxmlUnsignedLongAttributeDescription.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700131F RID: 4895
			// (get) Token: 0x06003FDC RID: 16348 RVA: 0x000FE1EC File Offset: 0x000FC3EC
			// (set) Token: 0x06003FDD RID: 16349 RVA: 0x0001AC57 File Offset: 0x00018E57
			public unsafe static Func<string, ulong, ulong> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UxmlUnsignedLongAttributeDescription.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, ulong, ulong>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UxmlUnsignedLongAttributeDescription.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D0F RID: 11535
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002D10 RID: 11536
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04002D11 RID: 11537
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D12 RID: 11538
			private static readonly IntPtr NativeMethodInfoPtr__GetValueFromBag_b__3_0_Internal_UInt64_String_UInt64_0;
		}

		// Token: 0x0200050E RID: 1294
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
