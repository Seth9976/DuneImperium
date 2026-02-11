using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Canis.skirmishScripts
{
	// Token: 0x0200004A RID: 74
	public class SkirmishInfo<T> : SkirmishInfo where T : MatchInitData
	{
		// Token: 0x0600049F RID: 1183 RVA: 0x0002BA4C File Offset: 0x00029C4C
		// Note: this type is marked as 'beforefieldinit'.
		static SkirmishInfo()
		{
			Il2CppClassPointerStore<SkirmishInfo<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.skirmishScripts", "SkirmishInfo`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SkirmishInfo<T>>.NativeClassPtr);
			SkirmishInfo<T>.NativeFieldInfoPtr_ChallengeData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SkirmishInfo<T>>.NativeClassPtr, "ChallengeData");
			SkirmishInfo<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SkirmishInfo<T>>.NativeClassPtr, 100664268);
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x0002BAE0 File Offset: 0x00029CE0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 542958, RefRangeEnd = 542962, XrefRangeStart = 542958, XrefRangeEnd = 542962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SkirmishInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SkirmishInfo<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SkirmishInfo<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00004020 File Offset: 0x00002220
		public SkirmishInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x0002BB1C File Offset: 0x00029D1C
		// (set) Token: 0x060004A3 RID: 1187 RVA: 0x0002BB44 File Offset: 0x00029D44
		public unsafe T ChallengeData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo<T>.NativeFieldInfoPtr_ChallengeData);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SkirmishInfo<T>.NativeFieldInfoPtr_ChallengeData);
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

		// Token: 0x040002FC RID: 764
		private static readonly IntPtr NativeFieldInfoPtr_ChallengeData;

		// Token: 0x040002FD RID: 765
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
