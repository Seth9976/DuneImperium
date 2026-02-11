using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x0200005F RID: 95
	public class Hash128Field : TextInputBaseField<Hash128>
	{
		// Token: 0x060008C1 RID: 2241 RVA: 0x0003C090 File Offset: 0x0003A290
		// Note: this type is marked as 'beforefieldinit'.
		static Hash128Field()
		{
			Il2CppClassPointerStore<Hash128Field>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "Hash128Field");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hash128Field>.NativeClassPtr);
			Hash128Field.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hash128Field>.NativeClassPtr, "ussClassName");
			Hash128Field.NativeFieldInfoPtr_labelUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hash128Field>.NativeClassPtr, "labelUssClassName");
			Hash128Field.NativeFieldInfoPtr_inputUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hash128Field>.NativeClassPtr, "inputUssClassName");
			Hash128Field.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128Field>.NativeClassPtr, 100664559);
			Hash128Field.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128Field>.NativeClassPtr, 100664560);
			Hash128Field.NativeMethodInfoPtr_get_value_Public_Virtual_get_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128Field>.NativeClassPtr, 100664561);
			Hash128Field.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128Field>.NativeClassPtr, 100664562);
			Hash128Field.NativeMethodInfoPtr_UpdateValueFromText_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128Field>.NativeClassPtr, 100664563);
			Hash128Field.NativeMethodInfoPtr_UpdateTextFromValue_Internal_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128Field>.NativeClassPtr, 100664564);
			Hash128Field.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128Field>.NativeClassPtr, 100664565);
			Hash128Field.NativeMethodInfoPtr_ValueToString_Protected_Virtual_String_Hash128_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128Field>.NativeClassPtr, 100664566);
			Hash128Field.NativeMethodInfoPtr_StringToValue_Protected_Virtual_Hash128_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128Field>.NativeClassPtr, 100664567);
			Hash128Field.NativeMethodInfoPtr_ExecuteDefaultAction_Protected_Virtual_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128Field>.NativeClassPtr, 100664568);
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x0003C1C4 File Offset: 0x0003A3C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295070, XrefRangeEnd = 295071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hash128Field()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hash128Field>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128Field.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x0003C200 File Offset: 0x0003A400
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 295111, RefRangeEnd = 295112, XrefRangeStart = 295071, XrefRangeEnd = 295111, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hash128Field(string label, int maxLength = -1)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hash128Field>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxLength;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128Field.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x060008C4 RID: 2244 RVA: 0x0003C25C File Offset: 0x0003A45C
		// (set) Token: 0x060008C5 RID: 2245 RVA: 0x0003C2A4 File Offset: 0x0003A4A4
		public unsafe override Hash128 value
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295112, XrefRangeEnd = 295115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hash128Field.NativeMethodInfoPtr_get_value_Public_Virtual_get_Hash128_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295115, XrefRangeEnd = 295125, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hash128Field.NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Hash128_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x0003C2F0 File Offset: 0x0003A4F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295125, XrefRangeEnd = 295129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateValueFromText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hash128Field.NativeMethodInfoPtr_UpdateValueFromText_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x0003C32C File Offset: 0x0003A52C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295129, XrefRangeEnd = 295135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UpdateTextFromValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hash128Field.NativeMethodInfoPtr_UpdateTextFromValue_Internal_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x0003C368 File Offset: 0x0003A568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295135, XrefRangeEnd = 295145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetValueWithoutNotify(Hash128 newValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref newValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hash128Field.NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_Hash128_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x0003C3B4 File Offset: 0x0003A5B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295145, XrefRangeEnd = 295146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ValueToString(Hash128 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hash128Field.NativeMethodInfoPtr_ValueToString_Protected_Virtual_String_Hash128_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060008CA RID: 2250 RVA: 0x0003C404 File Offset: 0x0003A604
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Hash128 StringToValue(string str)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hash128Field.NativeMethodInfoPtr_StringToValue_Protected_Virtual_Hash128_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008CB RID: 2251 RVA: 0x0003C45C File Offset: 0x0003A65C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295146, XrefRangeEnd = 295170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ExecuteDefaultAction(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hash128Field.NativeMethodInfoPtr_ExecuteDefaultAction_Protected_Virtual_Void_EventBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x00005159 File Offset: 0x00003359
		public Hash128Field(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x060008CD RID: 2253 RVA: 0x0003C4AC File Offset: 0x0003A6AC
		// (set) Token: 0x060008CE RID: 2254 RVA: 0x00005162 File Offset: 0x00003362
		public new unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Hash128Field.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hash128Field.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x060008CF RID: 2255 RVA: 0x0003C4CC File Offset: 0x0003A6CC
		// (set) Token: 0x060008D0 RID: 2256 RVA: 0x00005174 File Offset: 0x00003374
		public new unsafe static string labelUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Hash128Field.NativeFieldInfoPtr_labelUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hash128Field.NativeFieldInfoPtr_labelUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x060008D1 RID: 2257 RVA: 0x0003C4EC File Offset: 0x0003A6EC
		// (set) Token: 0x060008D2 RID: 2258 RVA: 0x00005186 File Offset: 0x00003386
		public new unsafe static string inputUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Hash128Field.NativeFieldInfoPtr_inputUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Hash128Field.NativeFieldInfoPtr_inputUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x060008D3 RID: 2259 RVA: 0x00005198 File Offset: 0x00003398
		public Hash128Field.Hash128Input integerInput
		{
			get
			{
				return base.textInputBase.Cast<Hash128Field.Hash128Input>();
			}
		}

		// Token: 0x04000621 RID: 1569
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x04000622 RID: 1570
		private static readonly IntPtr NativeFieldInfoPtr_labelUssClassName;

		// Token: 0x04000623 RID: 1571
		private static readonly IntPtr NativeFieldInfoPtr_inputUssClassName;

		// Token: 0x04000624 RID: 1572
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000625 RID: 1573
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;

		// Token: 0x04000626 RID: 1574
		private static readonly IntPtr NativeMethodInfoPtr_get_value_Public_Virtual_get_Hash128_0;

		// Token: 0x04000627 RID: 1575
		private static readonly IntPtr NativeMethodInfoPtr_set_value_Public_Virtual_set_Void_Hash128_0;

		// Token: 0x04000628 RID: 1576
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValueFromText_Internal_Virtual_Void_0;

		// Token: 0x04000629 RID: 1577
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTextFromValue_Internal_Virtual_Void_0;

		// Token: 0x0400062A RID: 1578
		private static readonly IntPtr NativeMethodInfoPtr_SetValueWithoutNotify_Public_Virtual_Void_Hash128_0;

		// Token: 0x0400062B RID: 1579
		private static readonly IntPtr NativeMethodInfoPtr_ValueToString_Protected_Virtual_String_Hash128_0;

		// Token: 0x0400062C RID: 1580
		private static readonly IntPtr NativeMethodInfoPtr_StringToValue_Protected_Virtual_Hash128_String_0;

		// Token: 0x0400062D RID: 1581
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteDefaultAction_Protected_Virtual_Void_EventBase_0;

		// Token: 0x0200037B RID: 891
		public new class UxmlFactory : UxmlFactory<Hash128Field, Hash128Field.UxmlTraits>
		{
			// Token: 0x060037C8 RID: 14280 RVA: 0x000171B8 File Offset: 0x000153B8
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlFactory()
			{
				Il2CppClassPointerStore<Hash128Field.UxmlFactory>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Hash128Field>.NativeClassPtr, "UxmlFactory");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hash128Field.UxmlFactory>.NativeClassPtr);
				Hash128Field.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128Field.UxmlFactory>.NativeClassPtr, 100664570);
			}

			// Token: 0x060037C9 RID: 14281 RVA: 0x000E458C File Offset: 0x000E278C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 295036, RefRangeEnd = 295037, XrefRangeStart = 295033, XrefRangeEnd = 295036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlFactory()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hash128Field.UxmlFactory>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128Field.UxmlFactory.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037CA RID: 14282 RVA: 0x000171EC File Offset: 0x000153EC
			public UxmlFactory(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040027B4 RID: 10164
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200037C RID: 892
		public new class UxmlTraits : TextValueFieldTraits<Hash128, UxmlHash128AttributeDescription>
		{
			// Token: 0x060037CB RID: 14283 RVA: 0x000171F5 File Offset: 0x000153F5
			// Note: this type is marked as 'beforefieldinit'.
			static UxmlTraits()
			{
				Il2CppClassPointerStore<Hash128Field.UxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Hash128Field>.NativeClassPtr, "UxmlTraits");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hash128Field.UxmlTraits>.NativeClassPtr);
				Hash128Field.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128Field.UxmlTraits>.NativeClassPtr, 100664571);
			}

			// Token: 0x060037CC RID: 14284 RVA: 0x000E45C8 File Offset: 0x000E27C8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295037, XrefRangeEnd = 295040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UxmlTraits()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hash128Field.UxmlTraits>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128Field.UxmlTraits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060037CD RID: 14285 RVA: 0x00017229 File Offset: 0x00015429
			public UxmlTraits(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040027B5 RID: 10165
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200037D RID: 893
		public class Hash128Input : TextInputBaseField<Hash128>.TextInputBase
		{
			// Token: 0x060037CE RID: 14286 RVA: 0x000E4604 File Offset: 0x000E2804
			// Note: this type is marked as 'beforefieldinit'.
			static Hash128Input()
			{
				Il2CppClassPointerStore<Hash128Field.Hash128Input>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Hash128Field>.NativeClassPtr, "Hash128Input");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hash128Field.Hash128Input>.NativeClassPtr);
				Hash128Field.Hash128Input.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128Field.Hash128Input>.NativeClassPtr, 100664572);
				Hash128Field.Hash128Input.NativeMethodInfoPtr_get_allowedCharacters_Protected_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128Field.Hash128Input>.NativeClassPtr, 100664573);
				Hash128Field.Hash128Input.NativeMethodInfoPtr_AcceptCharacter_Internal_Virtual_Boolean_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128Field.Hash128Input>.NativeClassPtr, 100664574);
				Hash128Field.Hash128Input.NativeMethodInfoPtr_StringToValue_Protected_Virtual_Hash128_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128Field.Hash128Input>.NativeClassPtr, 100664575);
				Hash128Field.Hash128Input.NativeMethodInfoPtr_Parse_Internal_Static_Hash128_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hash128Field.Hash128Input>.NativeClassPtr, 100664576);
			}

			// Token: 0x060037CF RID: 14287 RVA: 0x000E4694 File Offset: 0x000E2894
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295040, XrefRangeEnd = 295058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Hash128Input()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hash128Field.Hash128Input>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128Field.Hash128Input.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17001139 RID: 4409
			// (get) Token: 0x060037D0 RID: 14288 RVA: 0x000E46D0 File Offset: 0x000E28D0
			public unsafe string allowedCharacters
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295058, XrefRangeEnd = 295060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128Field.Hash128Input.NativeMethodInfoPtr_get_allowedCharacters_Protected_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060037D1 RID: 14289 RVA: 0x000E4708 File Offset: 0x000E2908
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295060, XrefRangeEnd = 295066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override bool AcceptCharacter(char c)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref c;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hash128Field.Hash128Input.NativeMethodInfoPtr_AcceptCharacter_Internal_Virtual_Boolean_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060037D2 RID: 14290 RVA: 0x000E475C File Offset: 0x000E295C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295066, XrefRangeEnd = 295068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Hash128 StringToValue(string str)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hash128Field.Hash128Input.NativeMethodInfoPtr_StringToValue_Protected_Virtual_Hash128_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060037D3 RID: 14291 RVA: 0x000E47B4 File Offset: 0x000E29B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295068, XrefRangeEnd = 295070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Hash128 Parse(string str)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hash128Field.Hash128Input.NativeMethodInfoPtr_Parse_Internal_Static_Hash128_String_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x060037D4 RID: 14292 RVA: 0x00017232 File Offset: 0x00015432
			public Hash128Input(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040027B6 RID: 10166
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x040027B7 RID: 10167
			private static readonly IntPtr NativeMethodInfoPtr_get_allowedCharacters_Protected_get_String_0;

			// Token: 0x040027B8 RID: 10168
			private static readonly IntPtr NativeMethodInfoPtr_AcceptCharacter_Internal_Virtual_Boolean_Char_0;

			// Token: 0x040027B9 RID: 10169
			private static readonly IntPtr NativeMethodInfoPtr_StringToValue_Protected_Virtual_Hash128_String_0;

			// Token: 0x040027BA RID: 10170
			private static readonly IntPtr NativeMethodInfoPtr_Parse_Internal_Static_Hash128_String_0;
		}
	}
}
