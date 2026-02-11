using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Globalization;

namespace UnityEngine.UIElements
{
	// Token: 0x020001FB RID: 507
	public class UxmlUnsignedIntAttributeDescription : TypedUxmlAttributeDescription<uint>
	{
		// Token: 0x060027B8 RID: 10168 RVA: 0x000AEDCC File Offset: 0x000ACFCC
		// Note: this type is marked as 'beforefieldinit'.
		static UxmlUnsignedIntAttributeDescription()
		{
			Il2CppClassPointerStore<UxmlUnsignedIntAttributeDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UxmlUnsignedIntAttributeDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlUnsignedIntAttributeDescription>.NativeClassPtr);
			UxmlUnsignedIntAttributeDescription.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlUnsignedIntAttributeDescription>.NativeClassPtr, 100669271);
			UxmlUnsignedIntAttributeDescription.NativeMethodInfoPtr_GetValueFromBag_Public_Virtual_UInt32_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlUnsignedIntAttributeDescription>.NativeClassPtr, 100669272);
			UxmlUnsignedIntAttributeDescription.NativeMethodInfoPtr_ConvertValueToUInt_Private_Static_UInt32_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlUnsignedIntAttributeDescription>.NativeClassPtr, 100669273);
		}

		// Token: 0x060027B9 RID: 10169 RVA: 0x000AEE38 File Offset: 0x000AD038
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343553, XrefRangeEnd = 343563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UxmlUnsignedIntAttributeDescription()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UxmlUnsignedIntAttributeDescription>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlUnsignedIntAttributeDescription.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027BA RID: 10170 RVA: 0x000AEE74 File Offset: 0x000AD074
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343563, XrefRangeEnd = 343582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override uint GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UxmlUnsignedIntAttributeDescription.NativeMethodInfoPtr_GetValueFromBag_Public_Virtual_UInt32_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027BB RID: 10171 RVA: 0x000AEEE4 File Offset: 0x000AD0E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343582, XrefRangeEnd = 343583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint ConvertValueToUInt(string v, uint defaultValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(v);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlUnsignedIntAttributeDescription.NativeMethodInfoPtr_ConvertValueToUInt_Private_Static_UInt32_String_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060027BC RID: 10172 RVA: 0x000101D7 File Offset: 0x0000E3D7
		public UxmlUnsignedIntAttributeDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x060027BD RID: 10173 RVA: 0x000AEF34 File Offset: 0x000AD134
		public override string defaultValueAsString
		{
			get
			{
				return base.defaultValue.ToString(CultureInfo.InvariantCulture.NumberFormat);
			}
		}

		// Token: 0x060027BE RID: 10174 RVA: 0x000101E0 File Offset: 0x0000E3E0
		public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref uint value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04001C3C RID: 7228
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001C3D RID: 7229
		private static readonly IntPtr NativeMethodInfoPtr_GetValueFromBag_Public_Virtual_UInt32_IUxmlAttributes_CreationContext_0;

		// Token: 0x04001C3E RID: 7230
		private static readonly IntPtr NativeMethodInfoPtr_ConvertValueToUInt_Private_Static_UInt32_String_UInt32_0;

		// Token: 0x0200050B RID: 1291
		[ObfuscatedName("UnityEngine.UIElements.UxmlUnsignedIntAttributeDescription+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06003FCE RID: 16334 RVA: 0x000FDF4C File Offset: 0x000FC14C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<UxmlUnsignedIntAttributeDescription.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<UxmlUnsignedIntAttributeDescription>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlUnsignedIntAttributeDescription.__c>.NativeClassPtr);
				UxmlUnsignedIntAttributeDescription.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlUnsignedIntAttributeDescription.__c>.NativeClassPtr, "<>9");
				UxmlUnsignedIntAttributeDescription.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlUnsignedIntAttributeDescription.__c>.NativeClassPtr, "<>9__3_0");
				UxmlUnsignedIntAttributeDescription.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlUnsignedIntAttributeDescription.__c>.NativeClassPtr, 100669275);
				UxmlUnsignedIntAttributeDescription.__c.NativeMethodInfoPtr__GetValueFromBag_b__3_0_Internal_UInt32_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlUnsignedIntAttributeDescription.__c>.NativeClassPtr, 100669276);
			}

			// Token: 0x06003FCF RID: 16335 RVA: 0x000FDFC8 File Offset: 0x000FC1C8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UxmlUnsignedIntAttributeDescription.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlUnsignedIntAttributeDescription.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06003FD0 RID: 16336 RVA: 0x000FE004 File Offset: 0x000FC204
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 343552, XrefRangeEnd = 343553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe uint _GetValueFromBag_b__3_0(string s, uint i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlUnsignedIntAttributeDescription.__c.NativeMethodInfoPtr__GetValueFromBag_b__3_0_Internal_UInt32_String_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06003FD1 RID: 16337 RVA: 0x0001AC0F File Offset: 0x00018E0F
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700131C RID: 4892
			// (get) Token: 0x06003FD2 RID: 16338 RVA: 0x000FE060 File Offset: 0x000FC260
			// (set) Token: 0x06003FD3 RID: 16339 RVA: 0x0001AC18 File Offset: 0x00018E18
			public unsafe static UxmlUnsignedIntAttributeDescription.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UxmlUnsignedIntAttributeDescription.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlUnsignedIntAttributeDescription.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UxmlUnsignedIntAttributeDescription.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700131D RID: 4893
			// (get) Token: 0x06003FD4 RID: 16340 RVA: 0x000FE088 File Offset: 0x000FC288
			// (set) Token: 0x06003FD5 RID: 16341 RVA: 0x0001AC2A File Offset: 0x00018E2A
			public unsafe static Func<string, uint, uint> __9__3_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(UxmlUnsignedIntAttributeDescription.__c.NativeFieldInfoPtr___9__3_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<string, uint, uint>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(UxmlUnsignedIntAttributeDescription.__c.NativeFieldInfoPtr___9__3_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04002D0B RID: 11531
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04002D0C RID: 11532
			private static readonly IntPtr NativeFieldInfoPtr___9__3_0;

			// Token: 0x04002D0D RID: 11533
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04002D0E RID: 11534
			private static readonly IntPtr NativeMethodInfoPtr__GetValueFromBag_b__3_0_Internal_UInt32_String_UInt32_0;
		}

		// Token: 0x0200050C RID: 1292
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
