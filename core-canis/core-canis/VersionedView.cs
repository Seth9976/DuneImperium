using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine;

// Token: 0x0200003B RID: 59
public class VersionedView<T> : MonoBehaviour where T : class
{
	// Token: 0x060004B7 RID: 1207 RVA: 0x00026074 File Offset: 0x00024274
	// Note: this type is marked as 'beforefieldinit'.
	static VersionedView()
	{
		Il2CppClassPointerStore<VersionedView<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "", "VersionedView`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VersionedView<T>>.NativeClassPtr);
		VersionedView<T>.NativeFieldInfoPtr_cachedModelVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionedView<T>>.NativeClassPtr, "cachedModelVersion");
		VersionedView<T>.NativeFieldInfoPtr__Model = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionedView<T>>.NativeClassPtr, "_Model");
		VersionedView<T>.NativeFieldInfoPtr_started = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionedView<T>>.NativeClassPtr, "started");
		VersionedView<T>.NativeMethodInfoPtr_get_currentModelVersion_Protected_Virtual_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedView<T>>.NativeClassPtr, 100663981);
		VersionedView<T>.NativeMethodInfoPtr_get_Model_Public_Virtual_New_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedView<T>>.NativeClassPtr, 100663982);
		VersionedView<T>.NativeMethodInfoPtr_set_Model_Public_Virtual_New_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedView<T>>.NativeClassPtr, 100663983);
		VersionedView<T>.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedView<T>>.NativeClassPtr, 100663984);
		VersionedView<T>.NativeMethodInfoPtr_start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedView<T>>.NativeClassPtr, 100663985);
		VersionedView<T>.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedView<T>>.NativeClassPtr, 100663986);
		VersionedView<T>.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedView<T>>.NativeClassPtr, 100663987);
		VersionedView<T>.NativeMethodInfoPtr_CheckDirtyUpdate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedView<T>>.NativeClassPtr, 100663988);
		VersionedView<T>.NativeMethodInfoPtr_modelChanged_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedView<T>>.NativeClassPtr, 100663989);
		VersionedView<T>.NativeMethodInfoPtr_dirtyUpdate_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedView<T>>.NativeClassPtr, 100663990);
		VersionedView<T>.NativeMethodInfoPtr_ClearModel_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedView<T>>.NativeClassPtr, 100663991);
		VersionedView<T>.NativeMethodInfoPtr_MarkDirty_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedView<T>>.NativeClassPtr, 100663992);
		VersionedView<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedView<T>>.NativeClassPtr, 100663993);
	}

	// Token: 0x17000167 RID: 359
	// (get) Token: 0x060004B8 RID: 1208 RVA: 0x00026220 File Offset: 0x00024420
	public unsafe virtual ulong currentModelVersion
	{
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 857095, RefRangeEnd = 857104, XrefRangeStart = 857091, XrefRangeEnd = 857095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VersionedView<T>.NativeMethodInfoPtr_get_currentModelVersion_Protected_Virtual_New_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x17000168 RID: 360
	// (get) Token: 0x060004B9 RID: 1209 RVA: 0x00026268 File Offset: 0x00024468
	// (set) Token: 0x060004BA RID: 1210 RVA: 0x000262AC File Offset: 0x000244AC
	public unsafe virtual T Model
	{
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VersionedView<T>.NativeMethodInfoPtr_get_Model_Public_Virtual_New_get_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857104, XrefRangeEnd = 857105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VersionedView<T>.NativeMethodInfoPtr_set_Model_Public_Virtual_New_set_Void_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}
	}

	// Token: 0x060004BB RID: 1211 RVA: 0x00026330 File Offset: 0x00024530
	[CallerCount(102)]
	[CachedScanResults(RefRangeStart = 857105, RefRangeEnd = 857207, XrefRangeStart = 857105, XrefRangeEnd = 857105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VersionedView<T>.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004BC RID: 1212 RVA: 0x0002636C File Offset: 0x0002456C
	[CallerCount(21425)]
	[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void start()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VersionedView<T>.NativeMethodInfoPtr_start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004BD RID: 1213 RVA: 0x000263A8 File Offset: 0x000245A8
	[CallerCount(6)]
	[CachedScanResults(RefRangeStart = 857207, RefRangeEnd = 857213, XrefRangeStart = 857207, XrefRangeEnd = 857207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void OnEnable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VersionedView<T>.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004BE RID: 1214 RVA: 0x000263E4 File Offset: 0x000245E4
	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 857213, RefRangeEnd = 857223, XrefRangeStart = 857213, XrefRangeEnd = 857213, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void Update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VersionedView<T>.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004BF RID: 1215 RVA: 0x00026420 File Offset: 0x00024620
	[CallerCount(10)]
	[CachedScanResults(RefRangeStart = 857213, RefRangeEnd = 857223, XrefRangeStart = 857213, XrefRangeEnd = 857223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void CheckDirtyUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedView<T>.NativeMethodInfoPtr_CheckDirtyUpdate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004C0 RID: 1216 RVA: 0x00026454 File Offset: 0x00024654
	[CallerCount(21425)]
	[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe virtual void modelChanged()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VersionedView<T>.NativeMethodInfoPtr_modelChanged_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004C1 RID: 1217 RVA: 0x00026490 File Offset: 0x00024690
	[CallerCount(0)]
	public unsafe virtual void dirtyUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VersionedView<T>.NativeMethodInfoPtr_dirtyUpdate_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004C2 RID: 1218 RVA: 0x000264CC File Offset: 0x000246CC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 857223, RefRangeEnd = 857224, XrefRangeStart = 857223, XrefRangeEnd = 857223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void ClearModel()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedView<T>.NativeMethodInfoPtr_ClearModel_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004C3 RID: 1219 RVA: 0x00026500 File Offset: 0x00024700
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 857224, RefRangeEnd = 857225, XrefRangeStart = 857224, XrefRangeEnd = 857224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public new unsafe void MarkDirty()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedView<T>.NativeMethodInfoPtr_MarkDirty_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004C4 RID: 1220 RVA: 0x00026534 File Offset: 0x00024734
	[CallerCount(311)]
	[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VersionedView()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionedView<T>>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedView<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x060004C5 RID: 1221 RVA: 0x00003C33 File Offset: 0x00001E33
	public VersionedView(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000164 RID: 356
	// (get) Token: 0x060004C6 RID: 1222 RVA: 0x00026570 File Offset: 0x00024770
	// (set) Token: 0x060004C7 RID: 1223 RVA: 0x00003C3C File Offset: 0x00001E3C
	public unsafe ulong cachedModelVersion
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedView<T>.NativeFieldInfoPtr_cachedModelVersion);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedView<T>.NativeFieldInfoPtr_cachedModelVersion)) = value;
		}
	}

	// Token: 0x17000165 RID: 357
	// (get) Token: 0x060004C8 RID: 1224 RVA: 0x00026598 File Offset: 0x00024798
	// (set) Token: 0x060004C9 RID: 1225 RVA: 0x000265C0 File Offset: 0x000247C0
	public unsafe T _Model
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedView<T>.NativeFieldInfoPtr__Model);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedView<T>.NativeFieldInfoPtr__Model);
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

	// Token: 0x17000166 RID: 358
	// (get) Token: 0x060004CA RID: 1226 RVA: 0x00026668 File Offset: 0x00024868
	// (set) Token: 0x060004CB RID: 1227 RVA: 0x00003C57 File Offset: 0x00001E57
	public unsafe bool started
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedView<T>.NativeFieldInfoPtr_started);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedView<T>.NativeFieldInfoPtr_started)) = value;
		}
	}

	// Token: 0x0400036F RID: 879
	private static readonly IntPtr NativeFieldInfoPtr_cachedModelVersion;

	// Token: 0x04000370 RID: 880
	private static readonly IntPtr NativeFieldInfoPtr__Model;

	// Token: 0x04000371 RID: 881
	private static readonly IntPtr NativeFieldInfoPtr_started;

	// Token: 0x04000372 RID: 882
	private static readonly IntPtr NativeMethodInfoPtr_get_currentModelVersion_Protected_Virtual_New_get_UInt64_0;

	// Token: 0x04000373 RID: 883
	private static readonly IntPtr NativeMethodInfoPtr_get_Model_Public_Virtual_New_get_T_0;

	// Token: 0x04000374 RID: 884
	private static readonly IntPtr NativeMethodInfoPtr_set_Model_Public_Virtual_New_set_Void_T_0;

	// Token: 0x04000375 RID: 885
	private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

	// Token: 0x04000376 RID: 886
	private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Virtual_New_Void_0;

	// Token: 0x04000377 RID: 887
	private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;

	// Token: 0x04000378 RID: 888
	private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

	// Token: 0x04000379 RID: 889
	private static readonly IntPtr NativeMethodInfoPtr_CheckDirtyUpdate_Protected_Void_0;

	// Token: 0x0400037A RID: 890
	private static readonly IntPtr NativeMethodInfoPtr_modelChanged_Protected_Virtual_New_Void_0;

	// Token: 0x0400037B RID: 891
	private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Abstract_Virtual_New_Void_0;

	// Token: 0x0400037C RID: 892
	private static readonly IntPtr NativeMethodInfoPtr_ClearModel_Public_Void_0;

	// Token: 0x0400037D RID: 893
	private static readonly IntPtr NativeMethodInfoPtr_MarkDirty_Public_Void_0;

	// Token: 0x0400037E RID: 894
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
}
