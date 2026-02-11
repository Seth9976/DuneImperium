using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200036E RID: 878
	public sealed class ParseRecord : Object
	{
		// Token: 0x06003679 RID: 13945 RVA: 0x0010CC9C File Offset: 0x0010AE9C
		// Note: this type is marked as 'beforefieldinit'.
		static ParseRecord()
		{
			Il2CppClassPointerStore<ParseRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "ParseRecord");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr);
			ParseRecord.NativeFieldInfoPtr_parseRecordIdCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "parseRecordIdCount");
			ParseRecord.NativeFieldInfoPtr_PRparseTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRparseTypeEnum");
			ParseRecord.NativeFieldInfoPtr_PRobjectTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRobjectTypeEnum");
			ParseRecord.NativeFieldInfoPtr_PRarrayTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRarrayTypeEnum");
			ParseRecord.NativeFieldInfoPtr_PRmemberTypeEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRmemberTypeEnum");
			ParseRecord.NativeFieldInfoPtr_PRmemberValueEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRmemberValueEnum");
			ParseRecord.NativeFieldInfoPtr_PRobjectPositionEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRobjectPositionEnum");
			ParseRecord.NativeFieldInfoPtr_PRname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRname");
			ParseRecord.NativeFieldInfoPtr_PRvalue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRvalue");
			ParseRecord.NativeFieldInfoPtr_PRvarValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRvarValue");
			ParseRecord.NativeFieldInfoPtr_PRkeyDt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRkeyDt");
			ParseRecord.NativeFieldInfoPtr_PRdtType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRdtType");
			ParseRecord.NativeFieldInfoPtr_PRdtTypeCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRdtTypeCode");
			ParseRecord.NativeFieldInfoPtr_PRisEnum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRisEnum");
			ParseRecord.NativeFieldInfoPtr_PRobjectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRobjectId");
			ParseRecord.NativeFieldInfoPtr_PRidRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRidRef");
			ParseRecord.NativeFieldInfoPtr_PRarrayElementTypeString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRarrayElementTypeString");
			ParseRecord.NativeFieldInfoPtr_PRarrayElementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRarrayElementType");
			ParseRecord.NativeFieldInfoPtr_PRisArrayVariant = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRisArrayVariant");
			ParseRecord.NativeFieldInfoPtr_PRarrayElementTypeCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRarrayElementTypeCode");
			ParseRecord.NativeFieldInfoPtr_PRrank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRrank");
			ParseRecord.NativeFieldInfoPtr_PRlengthA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRlengthA");
			ParseRecord.NativeFieldInfoPtr_PRpositionA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRpositionA");
			ParseRecord.NativeFieldInfoPtr_PRlowerBoundA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRlowerBoundA");
			ParseRecord.NativeFieldInfoPtr_PRupperBoundA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRupperBoundA");
			ParseRecord.NativeFieldInfoPtr_PRindexMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRindexMap");
			ParseRecord.NativeFieldInfoPtr_PRmemberIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRmemberIndex");
			ParseRecord.NativeFieldInfoPtr_PRlinearlength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRlinearlength");
			ParseRecord.NativeFieldInfoPtr_PRrectangularMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRrectangularMap");
			ParseRecord.NativeFieldInfoPtr_PRisLowerBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRisLowerBound");
			ParseRecord.NativeFieldInfoPtr_PRtopId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRtopId");
			ParseRecord.NativeFieldInfoPtr_PRheaderId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRheaderId");
			ParseRecord.NativeFieldInfoPtr_PRobjectInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRobjectInfo");
			ParseRecord.NativeFieldInfoPtr_PRisValueTypeFixup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRisValueTypeFixup");
			ParseRecord.NativeFieldInfoPtr_PRnewObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRnewObj");
			ParseRecord.NativeFieldInfoPtr_PRobjectA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRobjectA");
			ParseRecord.NativeFieldInfoPtr_PRprimitiveArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRprimitiveArray");
			ParseRecord.NativeFieldInfoPtr_PRisRegistered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRisRegistered");
			ParseRecord.NativeFieldInfoPtr_PRmemberData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRmemberData");
			ParseRecord.NativeFieldInfoPtr_PRsi = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRsi");
			ParseRecord.NativeFieldInfoPtr_PRnullCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, "PRnullCount");
			ParseRecord.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, 100671556);
			ParseRecord.NativeMethodInfoPtr_Init_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr, 100671557);
		}

		// Token: 0x0600367A RID: 13946 RVA: 0x0010D028 File Offset: 0x0010B228
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParseRecord()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParseRecord>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseRecord.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600367B RID: 13947 RVA: 0x0010D064 File Offset: 0x0010B264
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1390916, RefRangeEnd = 1390923, XrefRangeStart = 1390898, XrefRangeEnd = 1390916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParseRecord.NativeMethodInfoPtr_Init_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600367C RID: 13948 RVA: 0x000139E5 File Offset: 0x00011BE5
		public ParseRecord(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000CAF RID: 3247
		// (get) Token: 0x0600367D RID: 13949 RVA: 0x0010D098 File Offset: 0x0010B298
		// (set) Token: 0x0600367E RID: 13950 RVA: 0x000139EE File Offset: 0x00011BEE
		public unsafe static int parseRecordIdCount
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ParseRecord.NativeFieldInfoPtr_parseRecordIdCount, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ParseRecord.NativeFieldInfoPtr_parseRecordIdCount, (void*)(&value));
			}
		}

		// Token: 0x17000CB0 RID: 3248
		// (get) Token: 0x0600367F RID: 13951 RVA: 0x0010D0B4 File Offset: 0x0010B2B4
		// (set) Token: 0x06003680 RID: 13952 RVA: 0x000139FC File Offset: 0x00011BFC
		public unsafe InternalParseTypeE PRparseTypeEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRparseTypeEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRparseTypeEnum)) = value;
			}
		}

		// Token: 0x17000CB1 RID: 3249
		// (get) Token: 0x06003681 RID: 13953 RVA: 0x0010D0DC File Offset: 0x0010B2DC
		// (set) Token: 0x06003682 RID: 13954 RVA: 0x00013A17 File Offset: 0x00011C17
		public unsafe InternalObjectTypeE PRobjectTypeEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRobjectTypeEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRobjectTypeEnum)) = value;
			}
		}

		// Token: 0x17000CB2 RID: 3250
		// (get) Token: 0x06003683 RID: 13955 RVA: 0x0010D104 File Offset: 0x0010B304
		// (set) Token: 0x06003684 RID: 13956 RVA: 0x00013A32 File Offset: 0x00011C32
		public unsafe InternalArrayTypeE PRarrayTypeEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRarrayTypeEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRarrayTypeEnum)) = value;
			}
		}

		// Token: 0x17000CB3 RID: 3251
		// (get) Token: 0x06003685 RID: 13957 RVA: 0x0010D12C File Offset: 0x0010B32C
		// (set) Token: 0x06003686 RID: 13958 RVA: 0x00013A4D File Offset: 0x00011C4D
		public unsafe InternalMemberTypeE PRmemberTypeEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRmemberTypeEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRmemberTypeEnum)) = value;
			}
		}

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x06003687 RID: 13959 RVA: 0x0010D154 File Offset: 0x0010B354
		// (set) Token: 0x06003688 RID: 13960 RVA: 0x00013A68 File Offset: 0x00011C68
		public unsafe InternalMemberValueE PRmemberValueEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRmemberValueEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRmemberValueEnum)) = value;
			}
		}

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x06003689 RID: 13961 RVA: 0x0010D17C File Offset: 0x0010B37C
		// (set) Token: 0x0600368A RID: 13962 RVA: 0x00013A83 File Offset: 0x00011C83
		public unsafe InternalObjectPositionE PRobjectPositionEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRobjectPositionEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRobjectPositionEnum)) = value;
			}
		}

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x0600368B RID: 13963 RVA: 0x0010D1A4 File Offset: 0x0010B3A4
		// (set) Token: 0x0600368C RID: 13964 RVA: 0x00013A9E File Offset: 0x00011C9E
		public unsafe string PRname
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRname);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRname), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x0600368D RID: 13965 RVA: 0x0010D1CC File Offset: 0x0010B3CC
		// (set) Token: 0x0600368E RID: 13966 RVA: 0x00013ABD File Offset: 0x00011CBD
		public unsafe string PRvalue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRvalue);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRvalue), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x0600368F RID: 13967 RVA: 0x0010D1F4 File Offset: 0x0010B3F4
		// (set) Token: 0x06003690 RID: 13968 RVA: 0x00013ADC File Offset: 0x00011CDC
		public unsafe Object PRvarValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRvarValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRvarValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x06003691 RID: 13969 RVA: 0x0010D224 File Offset: 0x0010B424
		// (set) Token: 0x06003692 RID: 13970 RVA: 0x00013AFB File Offset: 0x00011CFB
		public unsafe string PRkeyDt
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRkeyDt);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRkeyDt), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x06003693 RID: 13971 RVA: 0x0010D24C File Offset: 0x0010B44C
		// (set) Token: 0x06003694 RID: 13972 RVA: 0x00013B1A File Offset: 0x00011D1A
		public unsafe Type PRdtType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRdtType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRdtType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x06003695 RID: 13973 RVA: 0x0010D27C File Offset: 0x0010B47C
		// (set) Token: 0x06003696 RID: 13974 RVA: 0x00013B39 File Offset: 0x00011D39
		public unsafe InternalPrimitiveTypeE PRdtTypeCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRdtTypeCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRdtTypeCode)) = value;
			}
		}

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x06003697 RID: 13975 RVA: 0x0010D2A4 File Offset: 0x0010B4A4
		// (set) Token: 0x06003698 RID: 13976 RVA: 0x00013B54 File Offset: 0x00011D54
		public unsafe bool PRisEnum
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRisEnum);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRisEnum)) = value;
			}
		}

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x06003699 RID: 13977 RVA: 0x0010D2CC File Offset: 0x0010B4CC
		// (set) Token: 0x0600369A RID: 13978 RVA: 0x00013B6F File Offset: 0x00011D6F
		public unsafe long PRobjectId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRobjectId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRobjectId)) = value;
			}
		}

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x0600369B RID: 13979 RVA: 0x0010D2F4 File Offset: 0x0010B4F4
		// (set) Token: 0x0600369C RID: 13980 RVA: 0x00013B8A File Offset: 0x00011D8A
		public unsafe long PRidRef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRidRef);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRidRef)) = value;
			}
		}

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x0600369D RID: 13981 RVA: 0x0010D31C File Offset: 0x0010B51C
		// (set) Token: 0x0600369E RID: 13982 RVA: 0x00013BA5 File Offset: 0x00011DA5
		public unsafe string PRarrayElementTypeString
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRarrayElementTypeString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRarrayElementTypeString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x0600369F RID: 13983 RVA: 0x0010D344 File Offset: 0x0010B544
		// (set) Token: 0x060036A0 RID: 13984 RVA: 0x00013BC4 File Offset: 0x00011DC4
		public unsafe Type PRarrayElementType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRarrayElementType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRarrayElementType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x060036A1 RID: 13985 RVA: 0x0010D374 File Offset: 0x0010B574
		// (set) Token: 0x060036A2 RID: 13986 RVA: 0x00013BE3 File Offset: 0x00011DE3
		public unsafe bool PRisArrayVariant
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRisArrayVariant);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRisArrayVariant)) = value;
			}
		}

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x060036A3 RID: 13987 RVA: 0x0010D39C File Offset: 0x0010B59C
		// (set) Token: 0x060036A4 RID: 13988 RVA: 0x00013BFE File Offset: 0x00011DFE
		public unsafe InternalPrimitiveTypeE PRarrayElementTypeCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRarrayElementTypeCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRarrayElementTypeCode)) = value;
			}
		}

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x060036A5 RID: 13989 RVA: 0x0010D3C4 File Offset: 0x0010B5C4
		// (set) Token: 0x060036A6 RID: 13990 RVA: 0x00013C19 File Offset: 0x00011E19
		public unsafe int PRrank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRrank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRrank)) = value;
			}
		}

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x060036A7 RID: 13991 RVA: 0x0010D3EC File Offset: 0x0010B5EC
		// (set) Token: 0x060036A8 RID: 13992 RVA: 0x00013C34 File Offset: 0x00011E34
		public unsafe Il2CppStructArray<int> PRlengthA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRlengthA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRlengthA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x060036A9 RID: 13993 RVA: 0x0010D41C File Offset: 0x0010B61C
		// (set) Token: 0x060036AA RID: 13994 RVA: 0x00013C53 File Offset: 0x00011E53
		public unsafe Il2CppStructArray<int> PRpositionA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRpositionA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRpositionA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC6 RID: 3270
		// (get) Token: 0x060036AB RID: 13995 RVA: 0x0010D44C File Offset: 0x0010B64C
		// (set) Token: 0x060036AC RID: 13996 RVA: 0x00013C72 File Offset: 0x00011E72
		public unsafe Il2CppStructArray<int> PRlowerBoundA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRlowerBoundA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRlowerBoundA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC7 RID: 3271
		// (get) Token: 0x060036AD RID: 13997 RVA: 0x0010D47C File Offset: 0x0010B67C
		// (set) Token: 0x060036AE RID: 13998 RVA: 0x00013C91 File Offset: 0x00011E91
		public unsafe Il2CppStructArray<int> PRupperBoundA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRupperBoundA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRupperBoundA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC8 RID: 3272
		// (get) Token: 0x060036AF RID: 13999 RVA: 0x0010D4AC File Offset: 0x0010B6AC
		// (set) Token: 0x060036B0 RID: 14000 RVA: 0x00013CB0 File Offset: 0x00011EB0
		public unsafe Il2CppStructArray<int> PRindexMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRindexMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRindexMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CC9 RID: 3273
		// (get) Token: 0x060036B1 RID: 14001 RVA: 0x0010D4DC File Offset: 0x0010B6DC
		// (set) Token: 0x060036B2 RID: 14002 RVA: 0x00013CCF File Offset: 0x00011ECF
		public unsafe int PRmemberIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRmemberIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRmemberIndex)) = value;
			}
		}

		// Token: 0x17000CCA RID: 3274
		// (get) Token: 0x060036B3 RID: 14003 RVA: 0x0010D504 File Offset: 0x0010B704
		// (set) Token: 0x060036B4 RID: 14004 RVA: 0x00013CEA File Offset: 0x00011EEA
		public unsafe int PRlinearlength
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRlinearlength);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRlinearlength)) = value;
			}
		}

		// Token: 0x17000CCB RID: 3275
		// (get) Token: 0x060036B5 RID: 14005 RVA: 0x0010D52C File Offset: 0x0010B72C
		// (set) Token: 0x060036B6 RID: 14006 RVA: 0x00013D05 File Offset: 0x00011F05
		public unsafe Il2CppStructArray<int> PRrectangularMap
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRrectangularMap);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRrectangularMap), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CCC RID: 3276
		// (get) Token: 0x060036B7 RID: 14007 RVA: 0x0010D55C File Offset: 0x0010B75C
		// (set) Token: 0x060036B8 RID: 14008 RVA: 0x00013D24 File Offset: 0x00011F24
		public unsafe bool PRisLowerBound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRisLowerBound);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRisLowerBound)) = value;
			}
		}

		// Token: 0x17000CCD RID: 3277
		// (get) Token: 0x060036B9 RID: 14009 RVA: 0x0010D584 File Offset: 0x0010B784
		// (set) Token: 0x060036BA RID: 14010 RVA: 0x00013D3F File Offset: 0x00011F3F
		public unsafe long PRtopId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRtopId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRtopId)) = value;
			}
		}

		// Token: 0x17000CCE RID: 3278
		// (get) Token: 0x060036BB RID: 14011 RVA: 0x0010D5AC File Offset: 0x0010B7AC
		// (set) Token: 0x060036BC RID: 14012 RVA: 0x00013D5A File Offset: 0x00011F5A
		public unsafe long PRheaderId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRheaderId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRheaderId)) = value;
			}
		}

		// Token: 0x17000CCF RID: 3279
		// (get) Token: 0x060036BD RID: 14013 RVA: 0x0010D5D4 File Offset: 0x0010B7D4
		// (set) Token: 0x060036BE RID: 14014 RVA: 0x00013D75 File Offset: 0x00011F75
		public unsafe ReadObjectInfo PRobjectInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRobjectInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadObjectInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRobjectInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD0 RID: 3280
		// (get) Token: 0x060036BF RID: 14015 RVA: 0x0010D604 File Offset: 0x0010B804
		// (set) Token: 0x060036C0 RID: 14016 RVA: 0x00013D94 File Offset: 0x00011F94
		public unsafe bool PRisValueTypeFixup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRisValueTypeFixup);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRisValueTypeFixup)) = value;
			}
		}

		// Token: 0x17000CD1 RID: 3281
		// (get) Token: 0x060036C1 RID: 14017 RVA: 0x0010D62C File Offset: 0x0010B82C
		// (set) Token: 0x060036C2 RID: 14018 RVA: 0x00013DAF File Offset: 0x00011FAF
		public unsafe Object PRnewObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRnewObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRnewObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD2 RID: 3282
		// (get) Token: 0x060036C3 RID: 14019 RVA: 0x0010D65C File Offset: 0x0010B85C
		// (set) Token: 0x060036C4 RID: 14020 RVA: 0x00013DCE File Offset: 0x00011FCE
		public unsafe Il2CppReferenceArray<Object> PRobjectA
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRobjectA);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRobjectA), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD3 RID: 3283
		// (get) Token: 0x060036C5 RID: 14021 RVA: 0x0010D68C File Offset: 0x0010B88C
		// (set) Token: 0x060036C6 RID: 14022 RVA: 0x00013DED File Offset: 0x00011FED
		public unsafe PrimitiveArray PRprimitiveArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRprimitiveArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PrimitiveArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRprimitiveArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD4 RID: 3284
		// (get) Token: 0x060036C7 RID: 14023 RVA: 0x0010D6BC File Offset: 0x0010B8BC
		// (set) Token: 0x060036C8 RID: 14024 RVA: 0x00013E0C File Offset: 0x0001200C
		public unsafe bool PRisRegistered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRisRegistered);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRisRegistered)) = value;
			}
		}

		// Token: 0x17000CD5 RID: 3285
		// (get) Token: 0x060036C9 RID: 14025 RVA: 0x0010D6E4 File Offset: 0x0010B8E4
		// (set) Token: 0x060036CA RID: 14026 RVA: 0x00013E27 File Offset: 0x00012027
		public unsafe Il2CppReferenceArray<Object> PRmemberData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRmemberData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRmemberData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD6 RID: 3286
		// (get) Token: 0x060036CB RID: 14027 RVA: 0x0010D714 File Offset: 0x0010B914
		// (set) Token: 0x060036CC RID: 14028 RVA: 0x00013E46 File Offset: 0x00012046
		public unsafe SerializationInfo PRsi
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRsi);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SerializationInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRsi), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000CD7 RID: 3287
		// (get) Token: 0x060036CD RID: 14029 RVA: 0x0010D744 File Offset: 0x0010B944
		// (set) Token: 0x060036CE RID: 14030 RVA: 0x00013E65 File Offset: 0x00012065
		public unsafe int PRnullCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRnullCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParseRecord.NativeFieldInfoPtr_PRnullCount)) = value;
			}
		}

		// Token: 0x04002C6B RID: 11371
		private static readonly IntPtr NativeFieldInfoPtr_parseRecordIdCount;

		// Token: 0x04002C6C RID: 11372
		private static readonly IntPtr NativeFieldInfoPtr_PRparseTypeEnum;

		// Token: 0x04002C6D RID: 11373
		private static readonly IntPtr NativeFieldInfoPtr_PRobjectTypeEnum;

		// Token: 0x04002C6E RID: 11374
		private static readonly IntPtr NativeFieldInfoPtr_PRarrayTypeEnum;

		// Token: 0x04002C6F RID: 11375
		private static readonly IntPtr NativeFieldInfoPtr_PRmemberTypeEnum;

		// Token: 0x04002C70 RID: 11376
		private static readonly IntPtr NativeFieldInfoPtr_PRmemberValueEnum;

		// Token: 0x04002C71 RID: 11377
		private static readonly IntPtr NativeFieldInfoPtr_PRobjectPositionEnum;

		// Token: 0x04002C72 RID: 11378
		private static readonly IntPtr NativeFieldInfoPtr_PRname;

		// Token: 0x04002C73 RID: 11379
		private static readonly IntPtr NativeFieldInfoPtr_PRvalue;

		// Token: 0x04002C74 RID: 11380
		private static readonly IntPtr NativeFieldInfoPtr_PRvarValue;

		// Token: 0x04002C75 RID: 11381
		private static readonly IntPtr NativeFieldInfoPtr_PRkeyDt;

		// Token: 0x04002C76 RID: 11382
		private static readonly IntPtr NativeFieldInfoPtr_PRdtType;

		// Token: 0x04002C77 RID: 11383
		private static readonly IntPtr NativeFieldInfoPtr_PRdtTypeCode;

		// Token: 0x04002C78 RID: 11384
		private static readonly IntPtr NativeFieldInfoPtr_PRisEnum;

		// Token: 0x04002C79 RID: 11385
		private static readonly IntPtr NativeFieldInfoPtr_PRobjectId;

		// Token: 0x04002C7A RID: 11386
		private static readonly IntPtr NativeFieldInfoPtr_PRidRef;

		// Token: 0x04002C7B RID: 11387
		private static readonly IntPtr NativeFieldInfoPtr_PRarrayElementTypeString;

		// Token: 0x04002C7C RID: 11388
		private static readonly IntPtr NativeFieldInfoPtr_PRarrayElementType;

		// Token: 0x04002C7D RID: 11389
		private static readonly IntPtr NativeFieldInfoPtr_PRisArrayVariant;

		// Token: 0x04002C7E RID: 11390
		private static readonly IntPtr NativeFieldInfoPtr_PRarrayElementTypeCode;

		// Token: 0x04002C7F RID: 11391
		private static readonly IntPtr NativeFieldInfoPtr_PRrank;

		// Token: 0x04002C80 RID: 11392
		private static readonly IntPtr NativeFieldInfoPtr_PRlengthA;

		// Token: 0x04002C81 RID: 11393
		private static readonly IntPtr NativeFieldInfoPtr_PRpositionA;

		// Token: 0x04002C82 RID: 11394
		private static readonly IntPtr NativeFieldInfoPtr_PRlowerBoundA;

		// Token: 0x04002C83 RID: 11395
		private static readonly IntPtr NativeFieldInfoPtr_PRupperBoundA;

		// Token: 0x04002C84 RID: 11396
		private static readonly IntPtr NativeFieldInfoPtr_PRindexMap;

		// Token: 0x04002C85 RID: 11397
		private static readonly IntPtr NativeFieldInfoPtr_PRmemberIndex;

		// Token: 0x04002C86 RID: 11398
		private static readonly IntPtr NativeFieldInfoPtr_PRlinearlength;

		// Token: 0x04002C87 RID: 11399
		private static readonly IntPtr NativeFieldInfoPtr_PRrectangularMap;

		// Token: 0x04002C88 RID: 11400
		private static readonly IntPtr NativeFieldInfoPtr_PRisLowerBound;

		// Token: 0x04002C89 RID: 11401
		private static readonly IntPtr NativeFieldInfoPtr_PRtopId;

		// Token: 0x04002C8A RID: 11402
		private static readonly IntPtr NativeFieldInfoPtr_PRheaderId;

		// Token: 0x04002C8B RID: 11403
		private static readonly IntPtr NativeFieldInfoPtr_PRobjectInfo;

		// Token: 0x04002C8C RID: 11404
		private static readonly IntPtr NativeFieldInfoPtr_PRisValueTypeFixup;

		// Token: 0x04002C8D RID: 11405
		private static readonly IntPtr NativeFieldInfoPtr_PRnewObj;

		// Token: 0x04002C8E RID: 11406
		private static readonly IntPtr NativeFieldInfoPtr_PRobjectA;

		// Token: 0x04002C8F RID: 11407
		private static readonly IntPtr NativeFieldInfoPtr_PRprimitiveArray;

		// Token: 0x04002C90 RID: 11408
		private static readonly IntPtr NativeFieldInfoPtr_PRisRegistered;

		// Token: 0x04002C91 RID: 11409
		private static readonly IntPtr NativeFieldInfoPtr_PRmemberData;

		// Token: 0x04002C92 RID: 11410
		private static readonly IntPtr NativeFieldInfoPtr_PRsi;

		// Token: 0x04002C93 RID: 11411
		private static readonly IntPtr NativeFieldInfoPtr_PRnullCount;

		// Token: 0x04002C94 RID: 11412
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04002C95 RID: 11413
		private static readonly IntPtr NativeMethodInfoPtr_Init_Internal_Void_0;
	}
}
