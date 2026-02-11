using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020002EE RID: 750
	public class CADMessageBase : Object
	{
		// Token: 0x06002E78 RID: 11896 RVA: 0x000EFEB0 File Offset: 0x000EE0B0
		// Note: this type is marked as 'beforefieldinit'.
		static CADMessageBase()
		{
			Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "CADMessageBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr);
			CADMessageBase.NativeFieldInfoPtr__args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, "_args");
			CADMessageBase.NativeFieldInfoPtr__serializedArgs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, "_serializedArgs");
			CADMessageBase.NativeFieldInfoPtr__propertyCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, "_propertyCount");
			CADMessageBase.NativeFieldInfoPtr__callContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, "_callContext");
			CADMessageBase.NativeFieldInfoPtr_serializedMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, "serializedMethod");
			CADMessageBase.NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100670692);
			CADMessageBase.NativeMethodInfoPtr_GetMethod_Internal_MethodBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100670693);
			CADMessageBase.NativeMethodInfoPtr_GetSignature_Protected_Static_Il2CppReferenceArray_1_Type_MethodBase_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100670694);
			CADMessageBase.NativeMethodInfoPtr_MarshalProperties_Internal_Static_Int32_IDictionary_byref_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100670695);
			CADMessageBase.NativeMethodInfoPtr_UnmarshalProperties_Internal_Static_Void_IDictionary_Int32_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100670696);
			CADMessageBase.NativeMethodInfoPtr_IsPossibleToIgnoreMarshal_Private_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100670697);
			CADMessageBase.NativeMethodInfoPtr_MarshalArgument_Protected_Object_Object_byref_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100670698);
			CADMessageBase.NativeMethodInfoPtr_UnmarshalArgument_Protected_Object_Object_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100670699);
			CADMessageBase.NativeMethodInfoPtr_MarshalArguments_Internal_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_byref_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100670700);
			CADMessageBase.NativeMethodInfoPtr_UnmarshalArguments_Internal_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100670701);
			CADMessageBase.NativeMethodInfoPtr_SaveLogicalCallContext_Protected_Void_IMethodMessage_byref_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100670702);
			CADMessageBase.NativeMethodInfoPtr_GetLogicalCallContext_Internal_LogicalCallContext_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr, 100670703);
		}

		// Token: 0x06002E79 RID: 11897 RVA: 0x000F0034 File Offset: 0x000EE234
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1382587, RefRangeEnd = 1382589, XrefRangeStart = 1382579, XrefRangeEnd = 1382587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CADMessageBase(IMethodMessage msg)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CADMessageBase>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMessageBase.NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002E7A RID: 11898 RVA: 0x000F0080 File Offset: 0x000EE280
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1382608, RefRangeEnd = 1382610, XrefRangeStart = 1382589, XrefRangeEnd = 1382608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethodBase GetMethod()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMessageBase.NativeMethodInfoPtr_GetMethod_Internal_MethodBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodBase>(intPtr3) : null;
		}

		// Token: 0x06002E7B RID: 11899 RVA: 0x000F00C0 File Offset: 0x000EE2C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1382626, RefRangeEnd = 1382627, XrefRangeStart = 1382610, XrefRangeEnd = 1382626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Type> GetSignature(MethodBase methodBase, bool load)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(methodBase);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref load;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMessageBase.NativeMethodInfoPtr_GetSignature_Protected_Static_Il2CppReferenceArray_1_Type_MethodBase_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr3) : null;
		}

		// Token: 0x06002E7C RID: 11900 RVA: 0x000F0114 File Offset: 0x000EE314
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1382680, RefRangeEnd = 1382682, XrefRangeStart = 1382627, XrefRangeEnd = 1382680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int MarshalProperties(IDictionary dict, ref ArrayList args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dict);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CADMessageBase.NativeMethodInfoPtr_MarshalProperties_Internal_Static_Int32_IDictionary_byref_ArrayList_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			args = ((intPtr4 == 0) ? null : new ArrayList(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002E7D RID: 11901 RVA: 0x000F0180 File Offset: 0x000EE380
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1382688, RefRangeEnd = 1382690, XrefRangeStart = 1382682, XrefRangeEnd = 1382688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnmarshalProperties(IDictionary dict, int count, ArrayList args)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dict);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMessageBase.NativeMethodInfoPtr_UnmarshalProperties_Internal_Static_Void_IDictionary_Int32_ArrayList_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E7E RID: 11902 RVA: 0x000F01D8 File Offset: 0x000EE3D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1382710, RefRangeEnd = 1382711, XrefRangeStart = 1382690, XrefRangeEnd = 1382710, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPossibleToIgnoreMarshal(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMessageBase.NativeMethodInfoPtr_IsPossibleToIgnoreMarshal_Private_Static_Boolean_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002E7F RID: 11903 RVA: 0x000F021C File Offset: 0x000EE41C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1382731, RefRangeEnd = 1382733, XrefRangeStart = 1382711, XrefRangeEnd = 1382731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object MarshalArgument(Object arg, ref ArrayList args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CADMessageBase.NativeMethodInfoPtr_MarshalArgument_Protected_Object_Object_byref_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			args = ((intPtr4 == 0) ? null : new ArrayList(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Object>(intPtr5) : null;
		}

		// Token: 0x06002E80 RID: 11904 RVA: 0x000F0298 File Offset: 0x000EE498
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1382769, RefRangeEnd = 1382772, XrefRangeStart = 1382733, XrefRangeEnd = 1382769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object UnmarshalArgument(Object arg, ArrayList args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMessageBase.NativeMethodInfoPtr_UnmarshalArgument_Protected_Object_Object_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002E81 RID: 11905 RVA: 0x000F02FC File Offset: 0x000EE4FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1382778, RefRangeEnd = 1382780, XrefRangeStart = 1382772, XrefRangeEnd = 1382778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Object> MarshalArguments(Il2CppReferenceArray<Object> arguments, ref ArrayList args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arguments);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(args);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CADMessageBase.NativeMethodInfoPtr_MarshalArguments_Internal_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_byref_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			args = ((intPtr4 == 0) ? null : new ArrayList(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr5) : null;
		}

		// Token: 0x06002E82 RID: 11906 RVA: 0x000F0378 File Offset: 0x000EE578
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1382786, RefRangeEnd = 1382790, XrefRangeStart = 1382780, XrefRangeEnd = 1382786, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Object> UnmarshalArguments(Il2CppReferenceArray<Object> arguments, ArrayList args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arguments);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMessageBase.NativeMethodInfoPtr_UnmarshalArguments_Internal_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06002E83 RID: 11907 RVA: 0x000F03DC File Offset: 0x000EE5DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1382807, RefRangeEnd = 1382808, XrefRangeStart = 1382790, XrefRangeEnd = 1382807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SaveLogicalCallContext(IMethodMessage msg, ref ArrayList serializeList)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(msg);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(serializeList);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CADMessageBase.NativeMethodInfoPtr_SaveLogicalCallContext_Protected_Void_IMethodMessage_byref_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			serializeList = ((intPtr4 == 0) ? null : new ArrayList(intPtr4));
		}

		// Token: 0x06002E84 RID: 11908 RVA: 0x000F0448 File Offset: 0x000EE648
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1382808, XrefRangeEnd = 1382811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LogicalCallContext GetLogicalCallContext(ArrayList args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMessageBase.NativeMethodInfoPtr_GetLogicalCallContext_Internal_LogicalCallContext_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LogicalCallContext>(intPtr3) : null;
			}
		}

		// Token: 0x06002E85 RID: 11909 RVA: 0x0000FCAA File Offset: 0x0000DEAA
		public CADMessageBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06002E86 RID: 11910 RVA: 0x000F0498 File Offset: 0x000EE698
		// (set) Token: 0x06002E87 RID: 11911 RVA: 0x0000FCB3 File Offset: 0x0000DEB3
		public unsafe Il2CppReferenceArray<Object> _args
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMessageBase.NativeFieldInfoPtr__args);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMessageBase.NativeFieldInfoPtr__args), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06002E88 RID: 11912 RVA: 0x000F04C8 File Offset: 0x000EE6C8
		// (set) Token: 0x06002E89 RID: 11913 RVA: 0x0000FCD2 File Offset: 0x0000DED2
		public unsafe Il2CppStructArray<byte> _serializedArgs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMessageBase.NativeFieldInfoPtr__serializedArgs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMessageBase.NativeFieldInfoPtr__serializedArgs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06002E8A RID: 11914 RVA: 0x000F04F8 File Offset: 0x000EE6F8
		// (set) Token: 0x06002E8B RID: 11915 RVA: 0x0000FCF1 File Offset: 0x0000DEF1
		public unsafe int _propertyCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMessageBase.NativeFieldInfoPtr__propertyCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMessageBase.NativeFieldInfoPtr__propertyCount)) = value;
			}
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06002E8C RID: 11916 RVA: 0x000F0520 File Offset: 0x000EE720
		// (set) Token: 0x06002E8D RID: 11917 RVA: 0x0000FD0C File Offset: 0x0000DF0C
		public unsafe CADArgHolder _callContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMessageBase.NativeFieldInfoPtr__callContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CADArgHolder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMessageBase.NativeFieldInfoPtr__callContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06002E8E RID: 11918 RVA: 0x000F0550 File Offset: 0x000EE750
		// (set) Token: 0x06002E8F RID: 11919 RVA: 0x0000FD2B File Offset: 0x0000DF2B
		public unsafe Il2CppStructArray<byte> serializedMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMessageBase.NativeFieldInfoPtr_serializedMethod);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMessageBase.NativeFieldInfoPtr_serializedMethod), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040026B9 RID: 9913
		private static readonly IntPtr NativeFieldInfoPtr__args;

		// Token: 0x040026BA RID: 9914
		private static readonly IntPtr NativeFieldInfoPtr__serializedArgs;

		// Token: 0x040026BB RID: 9915
		private static readonly IntPtr NativeFieldInfoPtr__propertyCount;

		// Token: 0x040026BC RID: 9916
		private static readonly IntPtr NativeFieldInfoPtr__callContext;

		// Token: 0x040026BD RID: 9917
		private static readonly IntPtr NativeFieldInfoPtr_serializedMethod;

		// Token: 0x040026BE RID: 9918
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IMethodMessage_0;

		// Token: 0x040026BF RID: 9919
		private static readonly IntPtr NativeMethodInfoPtr_GetMethod_Internal_MethodBase_0;

		// Token: 0x040026C0 RID: 9920
		private static readonly IntPtr NativeMethodInfoPtr_GetSignature_Protected_Static_Il2CppReferenceArray_1_Type_MethodBase_Boolean_0;

		// Token: 0x040026C1 RID: 9921
		private static readonly IntPtr NativeMethodInfoPtr_MarshalProperties_Internal_Static_Int32_IDictionary_byref_ArrayList_0;

		// Token: 0x040026C2 RID: 9922
		private static readonly IntPtr NativeMethodInfoPtr_UnmarshalProperties_Internal_Static_Void_IDictionary_Int32_ArrayList_0;

		// Token: 0x040026C3 RID: 9923
		private static readonly IntPtr NativeMethodInfoPtr_IsPossibleToIgnoreMarshal_Private_Static_Boolean_Object_0;

		// Token: 0x040026C4 RID: 9924
		private static readonly IntPtr NativeMethodInfoPtr_MarshalArgument_Protected_Object_Object_byref_ArrayList_0;

		// Token: 0x040026C5 RID: 9925
		private static readonly IntPtr NativeMethodInfoPtr_UnmarshalArgument_Protected_Object_Object_ArrayList_0;

		// Token: 0x040026C6 RID: 9926
		private static readonly IntPtr NativeMethodInfoPtr_MarshalArguments_Internal_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_byref_ArrayList_0;

		// Token: 0x040026C7 RID: 9927
		private static readonly IntPtr NativeMethodInfoPtr_UnmarshalArguments_Internal_Il2CppReferenceArray_1_Object_Il2CppReferenceArray_1_Object_ArrayList_0;

		// Token: 0x040026C8 RID: 9928
		private static readonly IntPtr NativeMethodInfoPtr_SaveLogicalCallContext_Protected_Void_IMethodMessage_byref_ArrayList_0;

		// Token: 0x040026C9 RID: 9929
		private static readonly IntPtr NativeMethodInfoPtr_GetLogicalCallContext_Internal_LogicalCallContext_ArrayList_0;
	}
}
