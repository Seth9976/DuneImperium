using System;
using dwd.core.commands;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Networking;

namespace dwd.core.direBytes
{
	// Token: 0x02000010 RID: 16
	public class DownloadTextBundleImages : Command
	{
		// Token: 0x060000B3 RID: 179 RVA: 0x0000570C File Offset: 0x0000390C
		// Note: this type is marked as 'beforefieldinit'.
		static DownloadTextBundleImages()
		{
			Il2CppClassPointerStore<DownloadTextBundleImages>.NativeClassPtr = IL2CPP.GetIl2CppClass("direbytes.dll", "dwd.core.direBytes", "DownloadTextBundleImages");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DownloadTextBundleImages>.NativeClassPtr);
			DownloadTextBundleImages.NativeFieldInfoPtr_client = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadTextBundleImages>.NativeClassPtr, "client");
			DownloadTextBundleImages.NativeFieldInfoPtr_imageNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadTextBundleImages>.NativeClassPtr, "imageNames");
			DownloadTextBundleImages.NativeFieldInfoPtr_imageFolderName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadTextBundleImages>.NativeClassPtr, "imageFolderName");
			DownloadTextBundleImages.NativeFieldInfoPtr_urlFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadTextBundleImages>.NativeClassPtr, "urlFormat");
			DownloadTextBundleImages.NativeMethodInfoPtr__ctor_Public_Void_String_HashSet_1_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadTextBundleImages>.NativeClassPtr, 100663386);
			DownloadTextBundleImages.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadTextBundleImages>.NativeClassPtr, 100663387);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000057B4 File Offset: 0x000039B4
		[CallerCount(128)]
		[CachedScanResults(RefRangeStart = 998618, RefRangeEnd = 998746, XrefRangeStart = 998618, XrefRangeEnd = 998746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DownloadTextBundleImages(string client, HashSet<string> imageNames, string imageFolderName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DownloadTextBundleImages>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(client);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(imageNames);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(imageFolderName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadTextBundleImages.NativeMethodInfoPtr__ctor_Public_Void_String_HashSet_1_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00005824 File Offset: 0x00003A24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234771, XrefRangeEnd = 1234776, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override IEnumerator execute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DownloadTextBundleImages.NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002597 File Offset: 0x00000797
		public DownloadTextBundleImages(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x00005870 File Offset: 0x00003A70
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x000025A0 File Offset: 0x000007A0
		public unsafe string client
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadTextBundleImages.NativeFieldInfoPtr_client);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadTextBundleImages.NativeFieldInfoPtr_client), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x00005898 File Offset: 0x00003A98
		// (set) Token: 0x060000BA RID: 186 RVA: 0x000025BF File Offset: 0x000007BF
		public unsafe HashSet<string> imageNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadTextBundleImages.NativeFieldInfoPtr_imageNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadTextBundleImages.NativeFieldInfoPtr_imageNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000BB RID: 187 RVA: 0x000058C8 File Offset: 0x00003AC8
		// (set) Token: 0x060000BC RID: 188 RVA: 0x000025DE File Offset: 0x000007DE
		public unsafe string imageFolderName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadTextBundleImages.NativeFieldInfoPtr_imageFolderName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadTextBundleImages.NativeFieldInfoPtr_imageFolderName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000BD RID: 189 RVA: 0x000058F0 File Offset: 0x00003AF0
		// (set) Token: 0x060000BE RID: 190 RVA: 0x000025FD File Offset: 0x000007FD
		public unsafe static string urlFormat
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DownloadTextBundleImages.NativeFieldInfoPtr_urlFormat, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DownloadTextBundleImages.NativeFieldInfoPtr_urlFormat, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeFieldInfoPtr_client;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeFieldInfoPtr_imageNames;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeFieldInfoPtr_imageFolderName;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeFieldInfoPtr_urlFormat;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_HashSet_1_String_String_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_execute_Protected_Virtual_IEnumerator_0;

		// Token: 0x02000033 RID: 51
		[ObfuscatedName("dwd.core.direBytes.DownloadTextBundleImages+<execute>d__5")]
		public sealed class _execute_d__5 : Object
		{
			// Token: 0x0600025D RID: 605 RVA: 0x00009EE0 File Offset: 0x000080E0
			// Note: this type is marked as 'beforefieldinit'.
			static _execute_d__5()
			{
				Il2CppClassPointerStore<DownloadTextBundleImages._execute_d__5>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DownloadTextBundleImages>.NativeClassPtr, "<execute>d__5");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DownloadTextBundleImages._execute_d__5>.NativeClassPtr);
				DownloadTextBundleImages._execute_d__5.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadTextBundleImages._execute_d__5>.NativeClassPtr, "<>1__state");
				DownloadTextBundleImages._execute_d__5.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadTextBundleImages._execute_d__5>.NativeClassPtr, "<>2__current");
				DownloadTextBundleImages._execute_d__5.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadTextBundleImages._execute_d__5>.NativeClassPtr, "<>4__this");
				DownloadTextBundleImages._execute_d__5.NativeFieldInfoPtr___7__wrap1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadTextBundleImages._execute_d__5>.NativeClassPtr, "<>7__wrap1");
				DownloadTextBundleImages._execute_d__5.NativeFieldInfoPtr__formattedImageName_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadTextBundleImages._execute_d__5>.NativeClassPtr, "<formattedImageName>5__3");
				DownloadTextBundleImages._execute_d__5.NativeFieldInfoPtr__url_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadTextBundleImages._execute_d__5>.NativeClassPtr, "<url>5__4");
				DownloadTextBundleImages._execute_d__5.NativeFieldInfoPtr__www_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DownloadTextBundleImages._execute_d__5>.NativeClassPtr, "<www>5__5");
				DownloadTextBundleImages._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadTextBundleImages._execute_d__5>.NativeClassPtr, 100663388);
				DownloadTextBundleImages._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadTextBundleImages._execute_d__5>.NativeClassPtr, 100663389);
				DownloadTextBundleImages._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadTextBundleImages._execute_d__5>.NativeClassPtr, 100663390);
				DownloadTextBundleImages._execute_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadTextBundleImages._execute_d__5>.NativeClassPtr, 100663391);
				DownloadTextBundleImages._execute_d__5.NativeMethodInfoPtr___m__Finally2_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadTextBundleImages._execute_d__5>.NativeClassPtr, 100663392);
				DownloadTextBundleImages._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadTextBundleImages._execute_d__5>.NativeClassPtr, 100663393);
				DownloadTextBundleImages._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadTextBundleImages._execute_d__5>.NativeClassPtr, 100663394);
				DownloadTextBundleImages._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DownloadTextBundleImages._execute_d__5>.NativeClassPtr, 100663395);
			}

			// Token: 0x0600025E RID: 606 RVA: 0x0000A038 File Offset: 0x00008238
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _execute_d__5(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DownloadTextBundleImages._execute_d__5>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadTextBundleImages._execute_d__5.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600025F RID: 607 RVA: 0x0000A080 File Offset: 0x00008280
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234667, XrefRangeEnd = 1234680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadTextBundleImages._execute_d__5.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000260 RID: 608 RVA: 0x0000A0B4 File Offset: 0x000082B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234680, XrefRangeEnd = 1234760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadTextBundleImages._execute_d__5.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06000261 RID: 609 RVA: 0x0000A0F0 File Offset: 0x000082F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234760, XrefRangeEnd = 1234763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadTextBundleImages._execute_d__5.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000262 RID: 610 RVA: 0x0000A124 File Offset: 0x00008324
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234763, XrefRangeEnd = 1234766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void __m__Finally2()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadTextBundleImages._execute_d__5.NativeMethodInfoPtr___m__Finally2_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000CC RID: 204
			// (get) Token: 0x06000263 RID: 611 RVA: 0x0000A158 File Offset: 0x00008358
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadTextBundleImages._execute_d__5.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000264 RID: 612 RVA: 0x0000A198 File Offset: 0x00008398
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1234766, XrefRangeEnd = 1234771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadTextBundleImages._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170000CD RID: 205
			// (get) Token: 0x06000265 RID: 613 RVA: 0x0000A1CC File Offset: 0x000083CC
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DownloadTextBundleImages._execute_d__5.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06000266 RID: 614 RVA: 0x00003632 File Offset: 0x00001832
			public _execute_d__5(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000C5 RID: 197
			// (get) Token: 0x06000267 RID: 615 RVA: 0x0000A20C File Offset: 0x0000840C
			// (set) Token: 0x06000268 RID: 616 RVA: 0x0000363B File Offset: 0x0000183B
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadTextBundleImages._execute_d__5.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadTextBundleImages._execute_d__5.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170000C6 RID: 198
			// (get) Token: 0x06000269 RID: 617 RVA: 0x0000A234 File Offset: 0x00008434
			// (set) Token: 0x0600026A RID: 618 RVA: 0x00003656 File Offset: 0x00001856
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadTextBundleImages._execute_d__5.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadTextBundleImages._execute_d__5.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000C7 RID: 199
			// (get) Token: 0x0600026B RID: 619 RVA: 0x0000A264 File Offset: 0x00008464
			// (set) Token: 0x0600026C RID: 620 RVA: 0x00003675 File Offset: 0x00001875
			public unsafe DownloadTextBundleImages __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadTextBundleImages._execute_d__5.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DownloadTextBundleImages>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadTextBundleImages._execute_d__5.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000C8 RID: 200
			// (get) Token: 0x0600026D RID: 621 RVA: 0x0000A294 File Offset: 0x00008494
			// (set) Token: 0x0600026E RID: 622 RVA: 0x00003694 File Offset: 0x00001894
			public HashSet<string>.Enumerator __7__wrap1
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadTextBundleImages._execute_d__5.NativeFieldInfoPtr___7__wrap1);
					return new HashSet<string>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<HashSet<string>.Enumerator>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadTextBundleImages._execute_d__5.NativeFieldInfoPtr___7__wrap1), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<HashSet<string>.Enumerator>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x170000C9 RID: 201
			// (get) Token: 0x0600026F RID: 623 RVA: 0x0000A2C4 File Offset: 0x000084C4
			// (set) Token: 0x06000270 RID: 624 RVA: 0x000036C2 File Offset: 0x000018C2
			public unsafe string _formattedImageName_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadTextBundleImages._execute_d__5.NativeFieldInfoPtr__formattedImageName_5__3);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadTextBundleImages._execute_d__5.NativeFieldInfoPtr__formattedImageName_5__3), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170000CA RID: 202
			// (get) Token: 0x06000271 RID: 625 RVA: 0x0000A2EC File Offset: 0x000084EC
			// (set) Token: 0x06000272 RID: 626 RVA: 0x000036E1 File Offset: 0x000018E1
			public unsafe string _url_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadTextBundleImages._execute_d__5.NativeFieldInfoPtr__url_5__4);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadTextBundleImages._execute_d__5.NativeFieldInfoPtr__url_5__4), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170000CB RID: 203
			// (get) Token: 0x06000273 RID: 627 RVA: 0x0000A314 File Offset: 0x00008514
			// (set) Token: 0x06000274 RID: 628 RVA: 0x00003700 File Offset: 0x00001900
			public unsafe UnityWebRequest _www_5__5
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadTextBundleImages._execute_d__5.NativeFieldInfoPtr__www_5__5);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DownloadTextBundleImages._execute_d__5.NativeFieldInfoPtr__www_5__5), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400014C RID: 332
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x0400014D RID: 333
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400014E RID: 334
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400014F RID: 335
			private static readonly IntPtr NativeFieldInfoPtr___7__wrap1;

			// Token: 0x04000150 RID: 336
			private static readonly IntPtr NativeFieldInfoPtr__formattedImageName_5__3;

			// Token: 0x04000151 RID: 337
			private static readonly IntPtr NativeFieldInfoPtr__url_5__4;

			// Token: 0x04000152 RID: 338
			private static readonly IntPtr NativeFieldInfoPtr__www_5__5;

			// Token: 0x04000153 RID: 339
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000154 RID: 340
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000155 RID: 341
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000156 RID: 342
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

			// Token: 0x04000157 RID: 343
			private static readonly IntPtr NativeMethodInfoPtr___m__Finally2_Private_Void_0;

			// Token: 0x04000158 RID: 344
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04000159 RID: 345
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400015A RID: 346
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
