using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

// Token: 0x0200003F RID: 63
public class Subscriber<T> : Subscriber where T : DataComponent
{
	// Token: 0x060004FD RID: 1277 RVA: 0x00027210 File Offset: 0x00025410
	// Note: this type is marked as 'beforefieldinit'.
	static Subscriber()
	{
		Il2CppClassPointerStore<Subscriber<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "", "Subscriber`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Subscriber<T>>.NativeClassPtr);
		Subscriber<T>.NativeFieldInfoPtr__Model_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Subscriber<T>>.NativeClassPtr, "<Model>k__BackingField");
		Subscriber<T>.NativeMethodInfoPtr_set_data_Protected_Virtual_Final_set_Void_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Subscriber<T>>.NativeClassPtr, 100664025);
		Subscriber<T>.NativeMethodInfoPtr_get_Model_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Subscriber<T>>.NativeClassPtr, 100664026);
		Subscriber<T>.NativeMethodInfoPtr_set_Model_Private_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Subscriber<T>>.NativeClassPtr, 100664027);
		Subscriber<T>.NativeMethodInfoPtr_get_model_Protected_Virtual_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Subscriber<T>>.NativeClassPtr, 100664028);
		Subscriber<T>.NativeMethodInfoPtr_set_model_Protected_Virtual_New_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Subscriber<T>>.NativeClassPtr, 100664029);
		Subscriber<T>.NativeMethodInfoPtr_modelChanged_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Subscriber<T>>.NativeClassPtr, 100664030);
		Subscriber<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Subscriber<T>>.NativeClassPtr, 100664031);
		Subscriber<T>.NativeMethodInfoPtr_get_data_Protected_Virtual_Final_get_DataComposition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Subscriber<T>>.NativeClassPtr, 100664032);
	}

	// Token: 0x17000176 RID: 374
	// (get) Token: 0x06000505 RID: 1285 RVA: 0x00027568 File Offset: 0x00025768
	// (set) Token: 0x060004FE RID: 1278 RVA: 0x00027330 File Offset: 0x00025530
	public unsafe override DataComposition data
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Subscriber<T>.NativeMethodInfoPtr_get_data_Protected_Virtual_Final_get_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DataComposition>(intPtr3) : null;
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857405, XrefRangeEnd = 857407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Subscriber<T>.NativeMethodInfoPtr_set_data_Protected_Virtual_Final_set_Void_DataComposition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}
	}

	// Token: 0x17000177 RID: 375
	// (get) Token: 0x060004FF RID: 1279 RVA: 0x00027374 File Offset: 0x00025574
	// (set) Token: 0x06000500 RID: 1280 RVA: 0x000273B0 File Offset: 0x000255B0
	public unsafe T Model
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Subscriber<T>.NativeMethodInfoPtr_get_Model_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Subscriber<T>.NativeMethodInfoPtr_set_Model_Private_set_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}
	}

	// Token: 0x17000178 RID: 376
	// (get) Token: 0x06000501 RID: 1281 RVA: 0x00027428 File Offset: 0x00025628
	// (set) Token: 0x06000502 RID: 1282 RVA: 0x0002746C File Offset: 0x0002566C
	public unsafe virtual T model
	{
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Subscriber<T>.NativeMethodInfoPtr_get_model_Protected_Virtual_New_get_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 857408, RefRangeEnd = 857409, XrefRangeStart = 857407, XrefRangeEnd = 857408, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		set
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = value;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Subscriber<T>.NativeMethodInfoPtr_set_model_Protected_Virtual_New_set_Void_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}
	}

	// Token: 0x06000503 RID: 1283 RVA: 0x000274F0 File Offset: 0x000256F0
	[CallerCount(21425)]
	[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void modelChanged()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Subscriber<T>.NativeMethodInfoPtr_modelChanged_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000504 RID: 1284 RVA: 0x0002752C File Offset: 0x0002572C
	[CallerCount(197)]
	[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe Subscriber()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Subscriber<T>>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Subscriber<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000506 RID: 1286 RVA: 0x00003D37 File Offset: 0x00001F37
	public Subscriber(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000175 RID: 373
	// (get) Token: 0x06000507 RID: 1287 RVA: 0x000275A8 File Offset: 0x000257A8
	// (set) Token: 0x06000508 RID: 1288 RVA: 0x000275D0 File Offset: 0x000257D0
	public unsafe T _Model_k__BackingField
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Subscriber<T>.NativeFieldInfoPtr__Model_k__BackingField);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Subscriber<T>.NativeFieldInfoPtr__Model_k__BackingField);
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

	// Token: 0x040003A3 RID: 931
	private static readonly IntPtr NativeFieldInfoPtr__Model_k__BackingField;

	// Token: 0x040003A4 RID: 932
	private static readonly IntPtr NativeMethodInfoPtr_set_data_Protected_Virtual_Final_set_Void_DataComposition_0;

	// Token: 0x040003A5 RID: 933
	private static readonly IntPtr NativeMethodInfoPtr_get_Model_Public_get_T_0;

	// Token: 0x040003A6 RID: 934
	private static readonly IntPtr NativeMethodInfoPtr_set_Model_Private_set_Void_T_0;

	// Token: 0x040003A7 RID: 935
	private static readonly IntPtr NativeMethodInfoPtr_get_model_Protected_Virtual_New_get_T_0;

	// Token: 0x040003A8 RID: 936
	private static readonly IntPtr NativeMethodInfoPtr_set_model_Protected_Virtual_New_set_Void_T_0;

	// Token: 0x040003A9 RID: 937
	private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_New_Void_0;

	// Token: 0x040003AA RID: 938
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

	// Token: 0x040003AB RID: 939
	private static readonly IntPtr NativeMethodInfoPtr_get_data_Protected_Virtual_Final_get_DataComposition_0;
}
