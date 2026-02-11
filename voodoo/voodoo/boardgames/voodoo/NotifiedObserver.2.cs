using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine;

namespace boardgames.voodoo
{
	// Token: 0x0200009E RID: 158
	public class NotifiedObserver<T> : NotifiedObserver where T : MonoBehaviour
	{
		// Token: 0x06000939 RID: 2361 RVA: 0x00027FDC File Offset: 0x000261DC
		// Note: this type is marked as 'beforefieldinit'.
		static NotifiedObserver()
		{
			Il2CppClassPointerStore<NotifiedObserver<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("voodoo.dll", "boardgames.voodoo", "NotifiedObserver`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotifiedObserver<T>>.NativeClassPtr);
			NotifiedObserver<T>.NativeFieldInfoPtr_notifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotifiedObserver<T>>.NativeClassPtr, "notifier");
			NotifiedObserver<T>.NativeMethodInfoPtr_get_Notifier_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotifiedObserver<T>>.NativeClassPtr, 100664641);
			NotifiedObserver<T>.NativeMethodInfoPtr_Start_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotifiedObserver<T>>.NativeClassPtr, 100664642);
			NotifiedObserver<T>.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotifiedObserver<T>>.NativeClassPtr, 100664643);
			NotifiedObserver<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotifiedObserver<T>>.NativeClassPtr, 100664644);
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x0600093A RID: 2362 RVA: 0x000280AC File Offset: 0x000262AC
		public unsafe T Notifier
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotifiedObserver<T>.NativeMethodInfoPtr_get_Notifier_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x000280E8 File Offset: 0x000262E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117260, XrefRangeEnd = 1117269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotifiedObserver<T>.NativeMethodInfoPtr_Start_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x0002811C File Offset: 0x0002631C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117269, XrefRangeEnd = 1117274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotifiedObserver<T>.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x00028150 File Offset: 0x00026350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117274, XrefRangeEnd = 1117275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotifiedObserver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotifiedObserver<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotifiedObserver<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x00006879 File Offset: 0x00004A79
		public NotifiedObserver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x0600093F RID: 2367 RVA: 0x0002818C File Offset: 0x0002638C
		// (set) Token: 0x06000940 RID: 2368 RVA: 0x000281B4 File Offset: 0x000263B4
		public unsafe T notifier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotifiedObserver<T>.NativeFieldInfoPtr_notifier);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotifiedObserver<T>.NativeFieldInfoPtr_notifier);
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

		// Token: 0x040005C2 RID: 1474
		private static readonly IntPtr NativeFieldInfoPtr_notifier;

		// Token: 0x040005C3 RID: 1475
		private static readonly IntPtr NativeMethodInfoPtr_get_Notifier_Public_get_T_0;

		// Token: 0x040005C4 RID: 1476
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Void_0;

		// Token: 0x040005C5 RID: 1477
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040005C6 RID: 1478
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
