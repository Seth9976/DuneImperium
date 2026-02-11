using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Linq.Expressions;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x0200010B RID: 267
	public class CallSite<T> : CallSite where T : class
	{
		// Token: 0x06000FEE RID: 4078 RVA: 0x00053D78 File Offset: 0x00051F78
		// Note: this type is marked as 'beforefieldinit'.
		static CallSite()
		{
			Il2CppClassPointerStore<CallSite<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Runtime.CompilerServices", "CallSite`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallSite<T>>.NativeClassPtr);
			CallSite<T>.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSite<T>>.NativeClassPtr, "Target");
			CallSite<T>.NativeFieldInfoPtr_Rules = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSite<T>>.NativeClassPtr, "Rules");
			CallSite<T>.NativeFieldInfoPtr_s_cachedUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSite<T>>.NativeClassPtr, "s_cachedUpdate");
			CallSite<T>.NativeFieldInfoPtr_s_cachedNoMatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSite<T>>.NativeClassPtr, "s_cachedNoMatch");
			CallSite<T>.NativeMethodInfoPtr_get_Update_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSite<T>>.NativeClassPtr, 100666261);
			CallSite<T>.NativeMethodInfoPtr__ctor_Private_Void_CallSiteBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSite<T>>.NativeClassPtr, 100666262);
			CallSite<T>.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSite<T>>.NativeClassPtr, 100666263);
			CallSite<T>.NativeMethodInfoPtr_CreateMatchMaker_Internal_CallSite_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSite<T>>.NativeClassPtr, 100666264);
			CallSite<T>.NativeMethodInfoPtr_Create_Public_Static_CallSite_1_T_CallSiteBinder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSite<T>>.NativeClassPtr, 100666265);
			CallSite<T>.NativeMethodInfoPtr_GetUpdateDelegate_Private_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSite<T>>.NativeClassPtr, 100666266);
			CallSite<T>.NativeMethodInfoPtr_GetUpdateDelegate_Private_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSite<T>>.NativeClassPtr, 100666267);
			CallSite<T>.NativeMethodInfoPtr_AddRule_Internal_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSite<T>>.NativeClassPtr, 100666268);
			CallSite<T>.NativeMethodInfoPtr_MoveRule_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSite<T>>.NativeClassPtr, 100666269);
			CallSite<T>.NativeMethodInfoPtr_MakeUpdateDelegate_Internal_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSite<T>>.NativeClassPtr, 100666270);
			CallSite<T>.NativeMethodInfoPtr_CreateCustomUpdateDelegate_Private_T_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSite<T>>.NativeClassPtr, 100666271);
			CallSite<T>.NativeMethodInfoPtr_CreateCustomNoMatchDelegate_Private_T_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSite<T>>.NativeClassPtr, 100666272);
			CallSite<T>.NativeMethodInfoPtr_Convert_Private_Static_Expression_Expression_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSite<T>>.NativeClassPtr, 100666273);
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06000FEF RID: 4079 RVA: 0x00053F38 File Offset: 0x00052138
		public unsafe T Update
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1027048, XrefRangeEnd = 1027049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSite<T>.NativeMethodInfoPtr_get_Update_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x00053F74 File Offset: 0x00052174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1027049, XrefRangeEnd = 1027052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallSite(CallSiteBinder binder)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallSite<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(binder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSite<T>.NativeMethodInfoPtr__ctor_Private_Void_CallSiteBinder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x00053FC0 File Offset: 0x000521C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1027052, XrefRangeEnd = 1027053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallSite()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallSite<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSite<T>.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x00053FFC File Offset: 0x000521FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1027056, RefRangeEnd = 1027057, XrefRangeStart = 1027053, XrefRangeEnd = 1027056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallSite<T> CreateMatchMaker()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSite<T>.NativeMethodInfoPtr_CreateMatchMaker_Internal_CallSite_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<CallSite<T>>(intPtr3) : null;
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x0005403C File Offset: 0x0005223C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1027075, RefRangeEnd = 1027077, XrefRangeStart = 1027057, XrefRangeEnd = 1027075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CallSite<T> Create(CallSiteBinder binder)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(binder);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSite<T>.NativeMethodInfoPtr_Create_Public_Static_CallSite_1_T_CallSiteBinder_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CallSite<T>>(intPtr3) : null;
			}
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x00054080 File Offset: 0x00052280
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1027093, RefRangeEnd = 1027095, XrefRangeStart = 1027077, XrefRangeEnd = 1027093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetUpdateDelegate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSite<T>.NativeMethodInfoPtr_GetUpdateDelegate_Private_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x000540BC File Offset: 0x000522BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1027095, XrefRangeEnd = 1027110, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetUpdateDelegate(ref T addr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(addr);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CallSite<T>.NativeMethodInfoPtr_GetUpdateDelegate_Private_T_byref_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				addr = ((intPtr4 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr4, false, false));
				return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
			}
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x00054120 File Offset: 0x00052320
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1027123, RefRangeEnd = 1027124, XrefRangeStart = 1027110, XrefRangeEnd = 1027123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddRule(T newRule)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = newRule;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref newRule;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CallSite<T>.NativeMethodInfoPtr_AddRule_Internal_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x00054198 File Offset: 0x00052398
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1027127, RefRangeEnd = 1027128, XrefRangeStart = 1027124, XrefRangeEnd = 1027127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveRule(int i)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref i;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSite<T>.NativeMethodInfoPtr_MoveRule_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x000541D8 File Offset: 0x000523D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1027128, XrefRangeEnd = 1027142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T MakeUpdateDelegate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSite<T>.NativeMethodInfoPtr_MakeUpdateDelegate_Internal_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x00054214 File Offset: 0x00052414
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1027462, RefRangeEnd = 1027465, XrefRangeStart = 1027142, XrefRangeEnd = 1027462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T CreateCustomUpdateDelegate(MethodInfo invoke)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(invoke);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSite<T>.NativeMethodInfoPtr_CreateCustomUpdateDelegate_Private_T_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x00054260 File Offset: 0x00052460
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1027513, RefRangeEnd = 1027516, XrefRangeStart = 1027465, XrefRangeEnd = 1027513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T CreateCustomNoMatchDelegate(MethodInfo invoke)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(invoke);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSite<T>.NativeMethodInfoPtr_CreateCustomNoMatchDelegate_Private_T_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x000542AC File Offset: 0x000524AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1027524, RefRangeEnd = 1027525, XrefRangeStart = 1027516, XrefRangeEnd = 1027524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Expression Convert(Expression arg, Type type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(arg);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSite<T>.NativeMethodInfoPtr_Convert_Private_Static_Expression_Expression_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x00006FB5 File Offset: 0x000051B5
		public CallSite(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06000FFD RID: 4093 RVA: 0x00054304 File Offset: 0x00052504
		// (set) Token: 0x06000FFE RID: 4094 RVA: 0x0005432C File Offset: 0x0005252C
		public unsafe T Target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSite<T>.NativeFieldInfoPtr_Target);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSite<T>.NativeFieldInfoPtr_Target);
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

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000FFF RID: 4095 RVA: 0x000543D4 File Offset: 0x000525D4
		// (set) Token: 0x06001000 RID: 4096 RVA: 0x00006FBE File Offset: 0x000051BE
		public unsafe Il2CppArrayBase<T> Rules
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSite<T>.NativeFieldInfoPtr_Rules);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallSite<T>.NativeFieldInfoPtr_Rules), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06001001 RID: 4097 RVA: 0x000543FC File Offset: 0x000525FC
		// (set) Token: 0x06001002 RID: 4098 RVA: 0x00054420 File Offset: 0x00052620
		public unsafe static T s_cachedUpdate
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CallSite<T>.NativeFieldInfoPtr_s_cachedUpdate, (void*)(&intPtr));
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, false);
			}
			set
			{
				IntPtr nativeFieldInfoPtr_s_cachedUpdate = CallSite<T>.NativeFieldInfoPtr_s_cachedUpdate;
				ref T ptr2;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					if (!(t is string))
					{
						ref T ptr = (ptr2 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr) != null)
						{
							ptr2 = ref ptr;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr)))
							{
								ptr2 = IL2CPP.il2cpp_object_unbox(ref ptr);
							}
						}
					}
					else
					{
						ptr2 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr2 = ref value;
				}
				IL2CPP.il2cpp_field_static_set_value(nativeFieldInfoPtr_s_cachedUpdate, (void*)(&ptr2));
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06001003 RID: 4099 RVA: 0x00054488 File Offset: 0x00052688
		// (set) Token: 0x06001004 RID: 4100 RVA: 0x000544AC File Offset: 0x000526AC
		public unsafe static T s_cachedNoMatch
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CallSite<T>.NativeFieldInfoPtr_s_cachedNoMatch, (void*)(&intPtr));
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, false);
			}
			set
			{
				IntPtr nativeFieldInfoPtr_s_cachedNoMatch = CallSite<T>.NativeFieldInfoPtr_s_cachedNoMatch;
				ref T ptr2;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					if (!(t is string))
					{
						ref T ptr = (ptr2 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
						if ((ref ptr) != null)
						{
							ptr2 = ref ptr;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr)))
							{
								ptr2 = IL2CPP.il2cpp_object_unbox(ref ptr);
							}
						}
					}
					else
					{
						ptr2 = IL2CPP.ManagedStringToIl2Cpp(t as string);
					}
				}
				else
				{
					ptr2 = ref value;
				}
				IL2CPP.il2cpp_field_static_set_value(nativeFieldInfoPtr_s_cachedNoMatch, (void*)(&ptr2));
			}
		}

		// Token: 0x04000B6E RID: 2926
		private static readonly IntPtr NativeFieldInfoPtr_Target;

		// Token: 0x04000B6F RID: 2927
		private static readonly IntPtr NativeFieldInfoPtr_Rules;

		// Token: 0x04000B70 RID: 2928
		private static readonly IntPtr NativeFieldInfoPtr_s_cachedUpdate;

		// Token: 0x04000B71 RID: 2929
		private static readonly IntPtr NativeFieldInfoPtr_s_cachedNoMatch;

		// Token: 0x04000B72 RID: 2930
		private static readonly IntPtr NativeMethodInfoPtr_get_Update_Public_get_T_0;

		// Token: 0x04000B73 RID: 2931
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_CallSiteBinder_0;

		// Token: 0x04000B74 RID: 2932
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000B75 RID: 2933
		private static readonly IntPtr NativeMethodInfoPtr_CreateMatchMaker_Internal_CallSite_1_T_0;

		// Token: 0x04000B76 RID: 2934
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_CallSite_1_T_CallSiteBinder_0;

		// Token: 0x04000B77 RID: 2935
		private static readonly IntPtr NativeMethodInfoPtr_GetUpdateDelegate_Private_T_0;

		// Token: 0x04000B78 RID: 2936
		private static readonly IntPtr NativeMethodInfoPtr_GetUpdateDelegate_Private_T_byref_T_0;

		// Token: 0x04000B79 RID: 2937
		private static readonly IntPtr NativeMethodInfoPtr_AddRule_Internal_Void_T_0;

		// Token: 0x04000B7A RID: 2938
		private static readonly IntPtr NativeMethodInfoPtr_MoveRule_Internal_Void_Int32_0;

		// Token: 0x04000B7B RID: 2939
		private static readonly IntPtr NativeMethodInfoPtr_MakeUpdateDelegate_Internal_T_0;

		// Token: 0x04000B7C RID: 2940
		private static readonly IntPtr NativeMethodInfoPtr_CreateCustomUpdateDelegate_Private_T_MethodInfo_0;

		// Token: 0x04000B7D RID: 2941
		private static readonly IntPtr NativeMethodInfoPtr_CreateCustomNoMatchDelegate_Private_T_MethodInfo_0;

		// Token: 0x04000B7E RID: 2942
		private static readonly IntPtr NativeMethodInfoPtr_Convert_Private_Static_Expression_Expression_Type_0;

		// Token: 0x0200032D RID: 813
		[ObfuscatedName("System.Runtime.CompilerServices.CallSite`1+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06001B45 RID: 6981 RVA: 0x00081938 File Offset: 0x0007FB38
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<CallSite<T>.__c>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CallSite<T>>.NativeClassPtr, "<>c"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallSite<T>.__c>.NativeClassPtr);
				CallSite<T>.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSite<T>.__c>.NativeClassPtr, "<>9");
				CallSite<T>.__c.NativeFieldInfoPtr___9__20_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSite<T>.__c>.NativeClassPtr, "<>9__20_0");
				CallSite<T>.__c.NativeFieldInfoPtr___9__20_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSite<T>.__c>.NativeClassPtr, "<>9__20_1");
				CallSite<T>.__c.NativeFieldInfoPtr___9__21_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallSite<T>.__c>.NativeClassPtr, "<>9__21_0");
				CallSite<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSite<T>.__c>.NativeClassPtr, 100666275);
				CallSite<T>.__c.NativeMethodInfoPtr__CreateCustomUpdateDelegate_b__20_0_Internal_ParameterExpression_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSite<T>.__c>.NativeClassPtr, 100666276);
				CallSite<T>.__c.NativeMethodInfoPtr__CreateCustomUpdateDelegate_b__20_1_Internal_Expression_ParameterExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSite<T>.__c>.NativeClassPtr, 100666277);
				CallSite<T>.__c.NativeMethodInfoPtr__CreateCustomNoMatchDelegate_b__21_0_Internal_ParameterExpression_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallSite<T>.__c>.NativeClassPtr, 100666278);
			}

			// Token: 0x06001B46 RID: 6982 RVA: 0x00081A40 File Offset: 0x0007FC40
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallSite<T>.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSite<T>.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001B47 RID: 6983 RVA: 0x00081A7C File Offset: 0x0007FC7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1027031, XrefRangeEnd = 1027036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ParameterExpression _CreateCustomUpdateDelegate_b__20_0(ParameterInfo p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSite<T>.__c.NativeMethodInfoPtr__CreateCustomUpdateDelegate_b__20_0_Internal_ParameterExpression_ParameterInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParameterExpression>(intPtr3) : null;
				}
			}

			// Token: 0x06001B48 RID: 6984 RVA: 0x00081ACC File Offset: 0x0007FCCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1027036, XrefRangeEnd = 1027043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Expression _CreateCustomUpdateDelegate_b__20_1(ParameterExpression p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSite<T>.__c.NativeMethodInfoPtr__CreateCustomUpdateDelegate_b__20_1_Internal_Expression_ParameterExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Expression>(intPtr3) : null;
				}
			}

			// Token: 0x06001B49 RID: 6985 RVA: 0x00081B1C File Offset: 0x0007FD1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1027043, XrefRangeEnd = 1027048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ParameterExpression _CreateCustomNoMatchDelegate_b__21_0(ParameterInfo p)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallSite<T>.__c.NativeMethodInfoPtr__CreateCustomNoMatchDelegate_b__21_0_Internal_ParameterExpression_ParameterInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ParameterExpression>(intPtr3) : null;
				}
			}

			// Token: 0x06001B4A RID: 6986 RVA: 0x0000A65B File Offset: 0x0000885B
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006E2 RID: 1762
			// (get) Token: 0x06001B4B RID: 6987 RVA: 0x00081B6C File Offset: 0x0007FD6C
			// (set) Token: 0x06001B4C RID: 6988 RVA: 0x0000A664 File Offset: 0x00008864
			public unsafe static CallSite<T>.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CallSite<T>.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallSite<T>.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CallSite<T>.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006E3 RID: 1763
			// (get) Token: 0x06001B4D RID: 6989 RVA: 0x00081B94 File Offset: 0x0007FD94
			// (set) Token: 0x06001B4E RID: 6990 RVA: 0x0000A676 File Offset: 0x00008876
			public unsafe static Converter<ParameterInfo, ParameterExpression> __9__20_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CallSite<T>.__c.NativeFieldInfoPtr___9__20_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Converter<ParameterInfo, ParameterExpression>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CallSite<T>.__c.NativeFieldInfoPtr___9__20_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006E4 RID: 1764
			// (get) Token: 0x06001B4F RID: 6991 RVA: 0x00081BBC File Offset: 0x0007FDBC
			// (set) Token: 0x06001B50 RID: 6992 RVA: 0x0000A688 File Offset: 0x00008888
			public unsafe static Converter<ParameterExpression, Expression> __9__20_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CallSite<T>.__c.NativeFieldInfoPtr___9__20_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Converter<ParameterExpression, Expression>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CallSite<T>.__c.NativeFieldInfoPtr___9__20_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006E5 RID: 1765
			// (get) Token: 0x06001B51 RID: 6993 RVA: 0x00081BE4 File Offset: 0x0007FDE4
			// (set) Token: 0x06001B52 RID: 6994 RVA: 0x0000A69A File Offset: 0x0000889A
			public unsafe static Converter<ParameterInfo, ParameterExpression> __9__21_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(CallSite<T>.__c.NativeFieldInfoPtr___9__21_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Converter<ParameterInfo, ParameterExpression>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(CallSite<T>.__c.NativeFieldInfoPtr___9__21_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400126F RID: 4719
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001270 RID: 4720
			private static readonly IntPtr NativeFieldInfoPtr___9__20_0;

			// Token: 0x04001271 RID: 4721
			private static readonly IntPtr NativeFieldInfoPtr___9__20_1;

			// Token: 0x04001272 RID: 4722
			private static readonly IntPtr NativeFieldInfoPtr___9__21_0;

			// Token: 0x04001273 RID: 4723
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001274 RID: 4724
			private static readonly IntPtr NativeMethodInfoPtr__CreateCustomUpdateDelegate_b__20_0_Internal_ParameterExpression_ParameterInfo_0;

			// Token: 0x04001275 RID: 4725
			private static readonly IntPtr NativeMethodInfoPtr__CreateCustomUpdateDelegate_b__20_1_Internal_Expression_ParameterExpression_0;

			// Token: 0x04001276 RID: 4726
			private static readonly IntPtr NativeMethodInfoPtr__CreateCustomNoMatchDelegate_b__21_0_Internal_ParameterExpression_ParameterInfo_0;
		}
	}
}
