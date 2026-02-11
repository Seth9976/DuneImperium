using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Globalization;

namespace UnityEngine.UIElements
{
	// Token: 0x020001F9 RID: 505
	public class UxmlDoubleAttributeDescription : TypedUxmlAttributeDescription<double>
	{
		// Token: 0x060027AA RID: 10154 RVA: 0x000AEA1C File Offset: 0x000ACC1C
		// Note: this type is marked as 'beforefieldinit'.
		static UxmlDoubleAttributeDescription()
		{
			Il2CppClassPointerStore<UxmlDoubleAttributeDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UxmlDoubleAttributeDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlDoubleAttributeDescription>.NativeClassPtr);
			UxmlDoubleAttributeDescription.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlDoubleAttributeDescription>.NativeClassPtr, 100669257);
			UxmlDoubleAttributeDescription.NativeMethodInfoPtr_GetValueFromBag_Public_Virtual_Double_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlDoubleAttributeDescription>.NativeClassPtr, 100669258);
			UxmlDoubleAttributeDescription.NativeMethodInfoPtr_ConvertValueToDouble_Private_Static_Double_String_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlDoubleAttributeDescription>.NativeClassPtr, 100669259);
		}

		// Token: 0x060027AB RID: 10155 RVA: 0x000AEA88 File Offset: 0x000ACC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343440, XrefRangeEnd = 343450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UxmlDoubleAttributeDescription()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UxmlDoubleAttributeDescription>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlDoubleAttributeDescription.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027AC RID: 10156 RVA: 0x000AEAC4 File Offset: 0x000ACCC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343450, XrefRangeEnd = 343469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override double GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UxmlDoubleAttributeDescription.NativeMethodInfoPtr_GetValueFromBag_Public_Virtual_Double_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027AD RID: 10157 RVA: 0x000AEB34 File Offset: 0x000ACD34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343469, XrefRangeEnd = 343474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static double ConvertValueToDouble(string v, double defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(v);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlDoubleAttributeDescription.NativeMethodInfoPtr_ConvertValueToDouble_Private_Static_Double_String_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027AE RID: 10158 RVA: 0x000101B8 File Offset: 0x0000E3B8
		public UxmlDoubleAttributeDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x060027AF RID: 10159 RVA: 0x000AEB84 File Offset: 0x000ACD84
		public override string defaultValueAsString
		{
			get
			{
				return base.defaultValue.ToString(CultureInfo.InvariantCulture.NumberFormat);
			}
		}

		// Token: 0x060027B0 RID: 10160 RVA: 0x000101C1 File Offset: 0x0000E3C1
		public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref double value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04001C35 RID: 7221
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001C36 RID: 7222
		private static readonly IntPtr NativeMethodInfoPtr_GetValueFromBag_Public_Virtual_Double_IUxmlAttributes_CreationContext_0;

		// Token: 0x04001C37 RID: 7223
		private static readonly IntPtr NativeMethodInfoPtr_ConvertValueToDouble_Private_Static_Double_String_Double_0;

		// Token: 0x02000507 RID: 1287
		[ObfuscatedName("UnityEngine.UIElements.UxmlDoubleAttributeDescription+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003FBB RID: 16315 RVA: 0x000FDBD8 File Offset: 0x000FBDD8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UxmlDoubleAttributeDescription.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UxmlDoubleAttributeDescription>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlDoubleAttributeDescription.__c>.NativeClassPtr);
				UxmlDoubleAttributeDescription.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlDoubleAttributeDescription.__c>.NativeClassPtr, "<>9");
				UxmlDoubleAttributeDescription.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlDoubleAttributeDescription.__c>.NativeClassPtr, "<>9__3_0");
				UxmlDoubleAttributeDescription.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlDoubleAttributeDescription.__c>.NativeClassPtr, 100669261);
				UxmlDoubleAttributeDescription.__c.NativeMethodInfoPtr__GetValueFromBag_b__3_0_Internal_Double_String_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlDoubleAttributeDescription.__c>.NativeClassPtr, 100669262);
			}

			// Token: 0x06003FBC RID: 16316 RVA: 0x000FDC54 File Offset: 0x000FBE54
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UxmlDoubleAttributeDescription.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlDoubleAttributeDescription.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003FBD RID: 16317 RVA: 0x000FDC90 File Offset: 0x000FBE90
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343435, XrefRangeEnd = 343440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe double _GetValueFromBag_b__3_0(string s, double d)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref d;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlDoubleAttributeDescription.__c.NativeMethodInfoPtr__GetValueFromBag_b__3_0_Internal_Double_String_Double_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003FBE RID: 16318 RVA: 0x0001ABA3 File Offset: 0x00018DA3
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001317 RID: 4887
			// (get) Token: 0x06003FBF RID: 16319 RVA: 0x000FDCEC File Offset: 0x000FBEEC
			// (set) Token: 0x06003FC0 RID: 16320 RVA: 0x0001ABAC File Offset: 0x00018DAC
			public unsafe static UxmlDoubleAttributeDescription.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UxmlDoubleAttributeDescription.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlDoubleAttributeDescription.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UxmlDoubleAttributeDescription.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001318 RID: 4888
			// (get) Token: 0x06003FC1 RID: 16321 RVA: 0x000FDD14 File Offset: 0x000FBF14
			// (set) Token: 0x06003FC2 RID: 16322 RVA: 0x0001ABBE File Offset: 0x00018DBE
			public unsafe static Func<string, double, double> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UxmlDoubleAttributeDescription.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, double, double>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UxmlDoubleAttributeDescription.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D01 RID: 11521
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002D02 RID: 11522
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04002D03 RID: 11523
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D04 RID: 11524
			private static readonly IntPtr NativeMethodInfoPtr__GetValueFromBag_b__3_0_Internal_Double_String_Double_0;
		}

		// Token: 0x02000508 RID: 1288
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
