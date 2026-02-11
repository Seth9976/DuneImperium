using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Globalization;

namespace UnityEngine.UIElements
{
	// Token: 0x020001F8 RID: 504
	public class UxmlFloatAttributeDescription : TypedUxmlAttributeDescription<float>
	{
		// Token: 0x060027A3 RID: 10147 RVA: 0x000AE888 File Offset: 0x000ACA88
		// Note: this type is marked as 'beforefieldinit'.
		static UxmlFloatAttributeDescription()
		{
			Il2CppClassPointerStore<UxmlFloatAttributeDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UxmlFloatAttributeDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlFloatAttributeDescription>.NativeClassPtr);
			UxmlFloatAttributeDescription.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlFloatAttributeDescription>.NativeClassPtr, 100669251);
			UxmlFloatAttributeDescription.NativeMethodInfoPtr_GetValueFromBag_Public_Virtual_Single_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlFloatAttributeDescription>.NativeClassPtr, 100669252);
			UxmlFloatAttributeDescription.NativeMethodInfoPtr_ConvertValueToFloat_Private_Static_Single_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlFloatAttributeDescription>.NativeClassPtr, 100669253);
		}

		// Token: 0x060027A4 RID: 10148 RVA: 0x000AE8F4 File Offset: 0x000ACAF4
		[CallerCount(37)]
		[CachedScanResults(RefRangeStart = 343374, RefRangeEnd = 343411, XrefRangeStart = 343364, XrefRangeEnd = 343374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UxmlFloatAttributeDescription()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UxmlFloatAttributeDescription>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlFloatAttributeDescription.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027A5 RID: 10149 RVA: 0x000AE930 File Offset: 0x000ACB30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343411, XrefRangeEnd = 343430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override float GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UxmlFloatAttributeDescription.NativeMethodInfoPtr_GetValueFromBag_Public_Virtual_Single_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027A6 RID: 10150 RVA: 0x000AE9A0 File Offset: 0x000ACBA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343430, XrefRangeEnd = 343435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static float ConvertValueToFloat(string v, float defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(v);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlFloatAttributeDescription.NativeMethodInfoPtr_ConvertValueToFloat_Private_Static_Single_String_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027A7 RID: 10151 RVA: 0x000101A2 File Offset: 0x0000E3A2
		public UxmlFloatAttributeDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x060027A8 RID: 10152 RVA: 0x000AE9F0 File Offset: 0x000ACBF0
		public override string defaultValueAsString
		{
			get
			{
				return base.defaultValue.ToString(CultureInfo.InvariantCulture.NumberFormat);
			}
		}

		// Token: 0x060027A9 RID: 10153 RVA: 0x000101AB File Offset: 0x0000E3AB
		public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref float value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04001C32 RID: 7218
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001C33 RID: 7219
		private static readonly IntPtr NativeMethodInfoPtr_GetValueFromBag_Public_Virtual_Single_IUxmlAttributes_CreationContext_0;

		// Token: 0x04001C34 RID: 7220
		private static readonly IntPtr NativeMethodInfoPtr_ConvertValueToFloat_Private_Static_Single_String_Single_0;

		// Token: 0x02000505 RID: 1285
		[ObfuscatedName("UnityEngine.UIElements.UxmlFloatAttributeDescription+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003FB3 RID: 16307 RVA: 0x000FDA74 File Offset: 0x000FBC74
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UxmlFloatAttributeDescription.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UxmlFloatAttributeDescription>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlFloatAttributeDescription.__c>.NativeClassPtr);
				UxmlFloatAttributeDescription.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlFloatAttributeDescription.__c>.NativeClassPtr, "<>9");
				UxmlFloatAttributeDescription.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlFloatAttributeDescription.__c>.NativeClassPtr, "<>9__3_0");
				UxmlFloatAttributeDescription.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlFloatAttributeDescription.__c>.NativeClassPtr, 100669255);
				UxmlFloatAttributeDescription.__c.NativeMethodInfoPtr__GetValueFromBag_b__3_0_Internal_Single_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlFloatAttributeDescription.__c>.NativeClassPtr, 100669256);
			}

			// Token: 0x06003FB4 RID: 16308 RVA: 0x000FDAF0 File Offset: 0x000FBCF0
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UxmlFloatAttributeDescription.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlFloatAttributeDescription.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003FB5 RID: 16309 RVA: 0x000FDB2C File Offset: 0x000FBD2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343359, XrefRangeEnd = 343364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe float _GetValueFromBag_b__3_0(string s, float f)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref f;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlFloatAttributeDescription.__c.NativeMethodInfoPtr__GetValueFromBag_b__3_0_Internal_Single_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003FB6 RID: 16310 RVA: 0x0001AB76 File Offset: 0x00018D76
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17001315 RID: 4885
			// (get) Token: 0x06003FB7 RID: 16311 RVA: 0x000FDB88 File Offset: 0x000FBD88
			// (set) Token: 0x06003FB8 RID: 16312 RVA: 0x0001AB7F File Offset: 0x00018D7F
			public unsafe static UxmlFloatAttributeDescription.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UxmlFloatAttributeDescription.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlFloatAttributeDescription.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UxmlFloatAttributeDescription.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17001316 RID: 4886
			// (get) Token: 0x06003FB9 RID: 16313 RVA: 0x000FDBB0 File Offset: 0x000FBDB0
			// (set) Token: 0x06003FBA RID: 16314 RVA: 0x0001AB91 File Offset: 0x00018D91
			public unsafe static Func<string, float, float> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UxmlFloatAttributeDescription.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, float, float>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UxmlFloatAttributeDescription.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002CFD RID: 11517
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002CFE RID: 11518
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04002CFF RID: 11519
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D00 RID: 11520
			private static readonly IntPtr NativeMethodInfoPtr__GetValueFromBag_b__3_0_Internal_Single_String_Single_0;
		}

		// Token: 0x02000506 RID: 1286
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
