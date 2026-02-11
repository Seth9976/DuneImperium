using System;
using dwd.core.data.composition;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

// Token: 0x02000041 RID: 65
public class VersionedSubscriber<T> : Subscriber<T> where T : DataComponent
{
	// Token: 0x06000522 RID: 1314 RVA: 0x00027D78 File Offset: 0x00025F78
	// Note: this type is marked as 'beforefieldinit'.
	static VersionedSubscriber()
	{
		Il2CppClassPointerStore<VersionedSubscriber<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "", "VersionedSubscriber`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VersionedSubscriber<T>>.NativeClassPtr);
		VersionedSubscriber<T>.NativeFieldInfoPtr_cached = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VersionedSubscriber<T>>.NativeClassPtr, "cached");
		VersionedSubscriber<T>.NativeMethodInfoPtr_get_model_Protected_Virtual_Final_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedSubscriber<T>>.NativeClassPtr, 100664050);
		VersionedSubscriber<T>.NativeMethodInfoPtr_set_model_Protected_Virtual_Final_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedSubscriber<T>>.NativeClassPtr, 100664051);
		VersionedSubscriber<T>.NativeMethodInfoPtr_get_version_Protected_Virtual_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedSubscriber<T>>.NativeClassPtr, 100664052);
		VersionedSubscriber<T>.NativeMethodInfoPtr_update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedSubscriber<T>>.NativeClassPtr, 100664053);
		VersionedSubscriber<T>.NativeMethodInfoPtr_onDisable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedSubscriber<T>>.NativeClassPtr, 100664054);
		VersionedSubscriber<T>.NativeMethodInfoPtr_dirtyUpdate_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedSubscriber<T>>.NativeClassPtr, 100664055);
		VersionedSubscriber<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VersionedSubscriber<T>>.NativeClassPtr, 100664056);
	}

	// Token: 0x1700017F RID: 383
	// (get) Token: 0x06000523 RID: 1315 RVA: 0x00027E84 File Offset: 0x00026084
	// (set) Token: 0x06000524 RID: 1316 RVA: 0x00027EC0 File Offset: 0x000260C0
	public unsafe override T model
	{
		[CallerCount(0)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedSubscriber<T>.NativeMethodInfoPtr_get_model_Protected_Virtual_Final_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 857585, XrefRangeEnd = 857587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(VersionedSubscriber<T>.NativeMethodInfoPtr_set_model_Protected_Virtual_Final_set_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}
	}

	// Token: 0x17000180 RID: 384
	// (get) Token: 0x06000525 RID: 1317 RVA: 0x00027F38 File Offset: 0x00026138
	public unsafe virtual ulong version
	{
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 857591, RefRangeEnd = 857592, XrefRangeStart = 857587, XrefRangeEnd = 857591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		get
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VersionedSubscriber<T>.NativeMethodInfoPtr_get_version_Protected_Virtual_New_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000526 RID: 1318 RVA: 0x00027F80 File Offset: 0x00026180
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 857592, RefRangeEnd = 857593, XrefRangeStart = 857592, XrefRangeEnd = 857592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void update()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VersionedSubscriber<T>.NativeMethodInfoPtr_update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000527 RID: 1319 RVA: 0x00027FBC File Offset: 0x000261BC
	[CallerCount(1)]
	[CachedScanResults(RefRangeStart = 857594, RefRangeEnd = 857595, XrefRangeStart = 857593, XrefRangeEnd = 857594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void onDisable()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VersionedSubscriber<T>.NativeMethodInfoPtr_onDisable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000528 RID: 1320 RVA: 0x00027FF8 File Offset: 0x000261F8
	[CallerCount(0)]
	public unsafe virtual void dirtyUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VersionedSubscriber<T>.NativeMethodInfoPtr_dirtyUpdate_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000529 RID: 1321 RVA: 0x00028034 File Offset: 0x00026234
	[CallerCount(90)]
	[CachedScanResults(RefRangeStart = 857596, RefRangeEnd = 857686, XrefRangeStart = 857595, XrefRangeEnd = 857596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe VersionedSubscriber()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VersionedSubscriber<T>>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VersionedSubscriber<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600052A RID: 1322 RVA: 0x00003DA6 File Offset: 0x00001FA6
	public VersionedSubscriber(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x1700017E RID: 382
	// (get) Token: 0x0600052B RID: 1323 RVA: 0x00028070 File Offset: 0x00026270
	// (set) Token: 0x0600052C RID: 1324 RVA: 0x00003DAF File Offset: 0x00001FAF
	public unsafe ulong cached
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedSubscriber<T>.NativeFieldInfoPtr_cached);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VersionedSubscriber<T>.NativeFieldInfoPtr_cached)) = value;
		}
	}

	// Token: 0x040003C0 RID: 960
	private static readonly IntPtr NativeFieldInfoPtr_cached;

	// Token: 0x040003C1 RID: 961
	private static readonly IntPtr NativeMethodInfoPtr_get_model_Protected_Virtual_Final_get_T_0;

	// Token: 0x040003C2 RID: 962
	private static readonly IntPtr NativeMethodInfoPtr_set_model_Protected_Virtual_Final_set_Void_T_0;

	// Token: 0x040003C3 RID: 963
	private static readonly IntPtr NativeMethodInfoPtr_get_version_Protected_Virtual_New_get_UInt64_0;

	// Token: 0x040003C4 RID: 964
	private static readonly IntPtr NativeMethodInfoPtr_update_Protected_Virtual_Void_0;

	// Token: 0x040003C5 RID: 965
	private static readonly IntPtr NativeMethodInfoPtr_onDisable_Protected_Virtual_Void_0;

	// Token: 0x040003C6 RID: 966
	private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Abstract_Virtual_New_Void_0;

	// Token: 0x040003C7 RID: 967
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
}
